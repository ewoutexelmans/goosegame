using System.Collections.Generic;
using System.Linq;
using GreenbeltGame.Core.Boards;
using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Players;
using GreenbeltGame.Infrastructure;

namespace GreenbeltGame.Core
{
    public class GooseGame
    {
        private readonly Dice _dice;
        private readonly BoardFactory _boardFactory;
        private readonly IUserInterface _userInterface;
        private readonly List<Player> _players;
        private List<Space> _board;
        private bool _gameHasEnded;
        private int _numberOfTurns;
        private const int FirstTurn = 1;

        public GooseGame(Dice dice, BoardFactory boardFactory, IUserInterface userInterface)
        {
            _dice = dice;
            _boardFactory = boardFactory;
            _userInterface = userInterface;
            _players = new List<Player>();
            _gameHasEnded = false;
        }

        public void Start(int numberOfPlayers)
        {
            _board = _boardFactory.CreateBoard();
            for (var i = 0; i < numberOfPlayers; i++)
            {
                _players.Add(new Player(_board.IndexOf(_board.First()), _board.IndexOf(_board.Last())));
            }
            _numberOfTurns = 0;
            // check player amount 2<=players<=4

            _userInterface.StartMessage(numberOfPlayers);
            GameLoop();
            End();
        }

        private void GameLoop()
        {
            while (!_gameHasEnded)
            {
                _numberOfTurns++;

                foreach (var player in _players)
                {
                    if (player.IsSkipped())
                    {
                        player.UpdateSkipTurnInfo();
                        continue;
                    }
                    DiceRoll(player);
                    CheckPlayerLocation(player);
                    if (player.HasWon) _gameHasEnded = true;
                }
                _userInterface.TurnMessage(_players, _numberOfTurns);
                if (!_gameHasEnded) _userInterface.NextTurn(_numberOfTurns);
            }
        }

        private void CheckPlayerLocation(Player player)
        {
            _board[player.Location].ApplyRules(player);
            if (player.IsTraveling)
            {
                CheckPlayerLocation(player);
            }
        }

        private void DiceRoll(Player player)
        {
            var diceRolls = player.DiceRolls = _dice.RollMultiple(2);
            if (_numberOfTurns == FirstTurn)
            {
                if (diceRolls.Contains(4) && diceRolls.Contains(5))
                {
                    player.Move(26);
                    return;
                }

                if (diceRolls.Contains(3) && diceRolls.Contains(6))
                {
                    player.Move(53);
                    return;
                }
            }
            player.Move(diceRolls.Sum());

        }

        private void End()
        {
            _userInterface.EndMessage(_players);
        }
    }
}
