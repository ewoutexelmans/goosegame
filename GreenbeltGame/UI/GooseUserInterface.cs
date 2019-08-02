using System;
using System.Collections.Generic;
using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Pieces;

namespace GreenbeltGame.UI
{
    public class GooseUserInterface : IUserInterface
    {
        public int GetNumberOfPieces(int lowerLimit, int upperLimit)
        {
            Console.WriteLine("[Enter the number of pieces you want to play with, and press ENTER]");
            int value;
            var condition = true;
            do
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out value) && value >= lowerLimit && value <= upperLimit)
                {
                    condition = false;
                }
                else
                {
                    Console.WriteLine($"[Please enter a number value between {lowerLimit} and {upperLimit}]");
                }
            } while (condition);

            return value;
        }

        public void StartMessage(int numberOfPieces)
        {
            var message = "\t";
            for (var i = 0; i < numberOfPieces; i++)
            {
                message += ToTable($"Piece {i + 1}");
            }

            Console.WriteLine(message);
        }

        public void TurnMessage(List<Piece> pieces, int numberOfTurns)
        {
            Console.WriteLine($"Turn {numberOfTurns}");
            var message = "\t";
            foreach (var piece in pieces)
            {
                message += ToTable(piece.TurnInfo);
            }

            Console.WriteLine(message);
        }

        public void NextTurn(int numberOfTurns)
        {
            Console.WriteLine($"[Press ENTER to play Turn {numberOfTurns + 1}]");
            UserInput();
        }

        public void EndMessage(List<Piece> pieces)
        {
            var message = "\t";
            foreach (var piece in pieces)
            {
                if (piece.HasWon)
                {
                    message += ToTable("WINNER!!!");
                }
                else
                {
                    message += ToTable("");
                }
            }

            Console.WriteLine(message);
            Console.WriteLine("[Press ENTER to FINISH GAME]");
            UserInput();
        }

        private static void UserInput()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        private static string ToTable(string s)
        {
            return s.PadRight(40);
        }
    }
}
