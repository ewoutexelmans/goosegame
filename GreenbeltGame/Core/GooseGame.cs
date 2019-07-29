using System;
using System.Collections.Generic;
using GreenbeltGame.Core.Pieces;
using GreenbeltGame.Infrastructure;

namespace GreenbeltGame.Core
{
    public class GooseGame
    {
        private readonly Dice _dice;
        private readonly List<Piece> _pieces;

        private bool GameHasEnded { get; set; }
        private int Turn { get; set; }

        public GooseGame(Dice dice)
        {
            _dice = dice;
            _pieces = new List<Piece>();

            GameHasEnded = false;

        }
        public void Start(int numberOfPlayers)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                _pieces.Add(new Piece(0));
            }
            Turn = 0;
            // check player amount 2<=players<=4

            // give start message in ui

            GameLoop();
            End();
        }

        private void GameLoop()
        {
            while (!GameHasEnded)
            {
                Turn++;
                foreach (var piece in _pieces)
                {
                    //roll dice
                    var diceRolls = _dice.RollMultiple(2);
                    //move player
                    piece.Move(diceRolls[0] + diceRolls[1]);
                    //check field player landed on and act accordingly

                    //check if player has won the game
                }
                //send turn to ui

            }
        }

        private void End()
        {
            //give end message in ui
        }


    }
}
