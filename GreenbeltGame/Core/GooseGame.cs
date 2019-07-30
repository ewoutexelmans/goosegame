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
        private readonly Board _board;
        private readonly IUserInterface _userInterface;
        private readonly List<Player> _players;
        private bool _gameHasEnded;
        private int _numberOfTurns;
        private const int FirstTurn = 1;

        public GooseGame(Dice dice, Board board, IUserInterface userInterface)
        {
            _dice = dice;
            _board = board;
            _userInterface = userInterface;
            _players = new List<Player>();
            _gameHasEnded = false;
        }

        public void Start(int numberOfPlayers)
        {
            for (var i = 0; i < numberOfPlayers; i++)
            {
                _players.Add(new Player(0));
            }
            _numberOfTurns = 0;
            // check player amount 2<=players<=4

            // give start message in ui
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
                    player.MovingForward = true;
                    DiceRoll(player);
                    if (player.Location == 63)
                    {
                        player.HasWon = true;
                        _gameHasEnded = true;
                    }
                    //check field player landed on and act accordingly
                    //check if player has won the game
                }
                //send turn to ui
                _userInterface.TurnMessage(_players, _numberOfTurns);
                if (!_gameHasEnded) _userInterface.NextTurn(_numberOfTurns);
            }
        }

        private void DiceRoll(Player player)
        {
            //roll dice
            var diceRolls = player.DiceRolls = _dice.RollMultiple(2);
            var diceRollTotal = diceRolls[0] + diceRolls[1];
            if (_numberOfTurns == FirstTurn)
            {
                if (diceRolls.Contains(4) && diceRolls.Contains(5))
                {
                    player.DiceRollMove(26);
                    return;
                }

                if (diceRolls.Contains(3) && diceRolls.Contains(6))
                {
                    player.DiceRollMove(53);
                    return;
                }
            }
            if (player.Location + diceRollTotal > 63)
            {
                player.MovingForward = false;

                player.DiceRollMove(2 * player.Location - 2 * 63 + diceRollTotal);
                return;
            }
            player.DiceRollMove(diceRollTotal);

        }

        private void End()
        {
            _userInterface.EndMessage(_players);
        }


    }
}
