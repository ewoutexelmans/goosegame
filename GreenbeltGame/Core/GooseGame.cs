using System;
using System.Collections.Generic;
using System.Linq;
using GreenbeltGame.Core.Players;
using GreenbeltGame.Infrastructure;

namespace GreenbeltGame.Core
{
    public class GooseGame
    {
        private readonly Dice _dice;
        private readonly Board.Board _board;
        private readonly List<Player> _players;
        private bool _gameHasEnded;
        private int _numberOfTurns;

        public GooseGame(Dice dice, Board.Board board)
        {
            _dice = dice;
            _board = board;
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

            GameLoop();
            End();
        }

        private void GameLoop()
        {
            while (!_gameHasEnded)
            {
                _numberOfTurns++;

                for (var i = 0; i < _players.Count; i++)
                {
                    _players[i].MovingForward = true;
                    DiceRoll(_players[i]);
                    if (_players[i].Location == 63)
                    {
                        _players[i].HasWon = true;
                        _gameHasEnded = true;
                    }
                    Console.WriteLine($"player {i}, rolled: {_players[i].DiceRolls[0]} + {_players[i].DiceRolls[1]}, moved to: {_players[i].Location}");
                    //check field player landed on and act accordingly
                    //check if player has won the game
                }
                //send turn to ui

            }
        }

        private void DiceRoll(Player player)
        {
            //roll dice
            var diceRolls = player.DiceRolls = _dice.RollMultiple(2);
            var diceRollTotal = diceRolls[0] + diceRolls[1];
            if (_numberOfTurns == 1)
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
            if (player.Location + diceRollTotal > 63)
            {
                player.MovingForward = false;

                player.Move(2 * player.Location - 2 * 63 + diceRollTotal);
                return;
            }
            player.Move(diceRollTotal);
        }

        private void End()
        {
            //give end message in ui
        }


    }
}
