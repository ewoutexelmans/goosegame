using System;
using System.Collections.Generic;
using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Pieces;

namespace GreenbeltGame.UI
{
    public class GooseUserInterface : IUserInterface
    {
        public void StartMessage(int numberOfPieces)
        {
            var message = "";
            for (var i = 0; i < numberOfPieces; i++)
            {
                message += ToTable($"Piece {i + 1}");
            }
            Console.WriteLine(message);
        }

        public void TurnMessage(List<Piece> pieces, int numberOfTurns)
        {
            Console.WriteLine($"Turn {numberOfTurns}");
            var message = "";
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
            var message = "";
            foreach (var piece in pieces)
            {
                if (piece.HasWon) message += ToTable("WINNER!!!");
                else message += ToTable("");

            }
            Console.WriteLine(message);
            Console.WriteLine("[Press ENTER to FINISH GAME]");
            UserInput();
        }

        public void PieceNumberErrorMessage()
        {
            Console.WriteLine("Number of pieces should be between 2 and 4");
            Console.WriteLine("[Press ENTER to CLOSE WINDOW]");
            UserInput();
        }

        private static void UserInput()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        private static string ToTable(string s)
        {
            return s.PadLeft(20);
        }
    }
}
