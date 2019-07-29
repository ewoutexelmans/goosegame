using System;
using GreenbeltGame.Core.Pieces;
using GreenbeltGame.Infrastructure;

namespace GreenbeltGame.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var piece = new Piece(0);
            var die = new Dice();
            for (int i = 0; i < 31; i++)
            {
                var rolls = die.RollMultiple(2);
                Console.WriteLine($"die 1: {rolls[0]}, die 2: {rolls[1]}");
                piece.Move(rolls[0] + rolls[1]);
                Console.WriteLine($"piece location: {piece.Location}");
            }

            Console.ReadKey();
        }
    }
}
