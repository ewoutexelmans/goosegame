using System.Collections.Generic;
using GreenbeltGame.Core;
using GreenbeltGame.Core.Boards;
using GreenbeltGame.Infrastructure;

namespace GreenbeltGame.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new GooseUserInterface();
            var boardSpaces = new List<Space> { new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space(), new Space() };
            var board = new Board(boardSpaces);
            var dice = new Dice();
            var gooseGame = new GooseGame(dice, board, ui);
            gooseGame.Start(4);

        }
    }
}
