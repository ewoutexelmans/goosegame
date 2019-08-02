using System;
using System.Collections.Generic;
using GreenbeltGame.Core;
using GreenbeltGame.Core.Boards;
using GreenbeltGame.Core.Model;
using GreenbeltGame.Infrastructure;
using GreenbeltGame.UI;

namespace GreenbeltGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new GooseUserInterface();
            var boardFactory = new BoardFactory(BoardSpaces);
            var random = new Random();
            var dice = new DiceSixSides(random);
            var gooseGame = new GooseGame(dice, boardFactory, ui);
            gooseGame.Create();
        }

        private static readonly List<SpaceType> BoardSpaces = new List<SpaceType> {
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Goose,
            SpaceType.Bridge,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Goose,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Goose,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Goose,
            SpaceType.Inn,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Goose,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Goose,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Well,
            SpaceType.Goose,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Goose,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Goose,
            SpaceType.Maze,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Goose,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Goose,
            SpaceType.Regular,
            SpaceType.Prison,
            SpaceType.Regular,
            SpaceType.Goose,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Death,
            SpaceType.Goose,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.Regular,
            SpaceType.End
        };
    }
}
