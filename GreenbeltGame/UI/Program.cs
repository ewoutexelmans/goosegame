using System;
using System.Collections.Generic;
using GreenbeltGame.Core;
using GreenbeltGame.Core.Board;
using GreenbeltGame.Infrastructure;

namespace GreenbeltGame.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardSpaces = new List<Space> { new Space(),
                new Space(),
                new Space(),
                new Space(),
                new Space(),
                new Space(),
                new Space(),
                new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space() };
            var board = new Board(boardSpaces);
            var dice = new Dice();
            var gooseGame = new GooseGame(dice, board);
            gooseGame.Start(4);

            Console.ReadKey();
        }
    }
}
