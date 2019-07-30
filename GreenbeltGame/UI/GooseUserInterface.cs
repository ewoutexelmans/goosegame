using System;
using System.Collections.Generic;
using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Players;

namespace GreenbeltGame.UI
{
    public class GooseUserInterface : IUserInterface
    {
        public void StartMessage(int numberOfPlayers)
        {
            var message = "";
            for (var i = 0; i < numberOfPlayers; i++)
            {
                message += $"Piece {i + 1}".PadLeft(20);
            }
            Console.WriteLine(message);
        }

        public void TurnMessage(List<Player> players, int numberOfTurns)
        {
            Console.WriteLine($"Turn {numberOfTurns}");
            var message = "";
            foreach (var player in players)
            {
                message += player.TurnInfo.PadLeft(20);
            }
            Console.WriteLine(message);

        }

        public void NextTurn(int numberOfTurns)
        {
            Console.WriteLine($"[Press ENTER to play Turn {numberOfTurns + 1}]");
            Console.ReadKey();
        }

        public void EndMessage(List<Player> players)
        {
            var message = "";
            foreach (var player in players)
            {
                if (player.HasWon) message += "WINNER".PadLeft(20);
                else message += "".PadLeft(20);

            }
            Console.WriteLine(message);
            Console.WriteLine("[Press ENTER to FINISH GAME]");
            Console.ReadKey();
        }
    }
}
