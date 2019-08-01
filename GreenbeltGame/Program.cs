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
            var dice = new Dice();
            var gooseGame = new GooseGame(dice, boardFactory, ui);
            gooseGame.Create(4);
        }

        private static readonly List<SpaceType> BoardSpaces = new List<SpaceType> {
            SpaceType.Regular, //0 Start
            SpaceType.Regular, //1
            SpaceType.Regular, //2
            SpaceType.Regular, //3
            SpaceType.Regular, //4
            SpaceType.Goose, //5 Goose
            SpaceType.Bridge, //6 Bridge
            SpaceType.Regular, //7
            SpaceType.Regular, //8
            SpaceType.Goose, //9 Goose
            SpaceType.Regular, //10
            SpaceType.Regular, //11
            SpaceType.Regular, //12
            SpaceType.Regular, //13
            SpaceType.Goose, //14 Goose
            SpaceType.Regular, //15
            SpaceType.Regular, //16
            SpaceType.Regular, //17
            SpaceType.Goose, //18 Goose
            SpaceType.Inn, //19 Inn
            SpaceType.Regular, //20
            SpaceType.Regular, //21
            SpaceType.Regular, //22
            SpaceType.Goose, //23 Goose
            SpaceType.Regular, //24
            SpaceType.Regular, //25
            SpaceType.Regular, //26
            SpaceType.Goose, //27 Goose
            SpaceType.Regular, //28
            SpaceType.Regular, //29
            SpaceType.Regular, //30
            SpaceType.Well, //31 Well
            SpaceType.Goose, //32 Goose
            SpaceType.Regular, //33
            SpaceType.Regular, //34
            SpaceType.Regular, //35
            SpaceType.Goose, //36 Goose
            SpaceType.Regular, //37
            SpaceType.Regular, //38
            SpaceType.Regular, //39
            SpaceType.Regular, //40
            SpaceType.Goose, //41 Goose
            SpaceType.Maze, //42 Maze
            SpaceType.Regular, //43
            SpaceType.Regular, //44
            SpaceType.Goose, //45 Goose
            SpaceType.Regular, //46
            SpaceType.Regular, //47
            SpaceType.Regular, //48
            SpaceType.Regular, //49
            SpaceType.Goose, //50 Goose
            SpaceType.Regular, //51
            SpaceType.Prison, //52 Prison
            SpaceType.Regular, //53
            SpaceType.Goose, //54 Goose
            SpaceType.Regular, //55
            SpaceType.Regular, //56
            SpaceType.Regular, //57 
            SpaceType.Death, //58 Death
            SpaceType.Goose, //59 Goose
            SpaceType.Regular, //60
            SpaceType.Regular, //61
            SpaceType.Regular, //62
            SpaceType.End //63 End
        };

    }
}
