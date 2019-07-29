using System;
using GreenbeltGame.Core;
using GreenbeltGame.Infrastructure;

namespace GreenbeltGame.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var dice = new Dice();
            var gooseGame = new GooseGame(dice);
            gooseGame.Start(4);

            Console.ReadKey();
        }
    }
}
