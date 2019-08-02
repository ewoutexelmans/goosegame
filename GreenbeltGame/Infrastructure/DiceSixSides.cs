using System;
using GreenbeltGame.Core.Interfaces;

namespace GreenbeltGame.Infrastructure
{

    public class DiceSixSides : IDice
    {
        private readonly Random _random;

        public DiceSixSides(Random random)
        {
            _random = random;
        }
        public int Roll()
        {
            return _random.Next(1, 7);
        }

        public int[] RollMultiple(int numberOfDice)
        {
            var diceRolls = new int[numberOfDice];
            for (var i = 0; i < diceRolls.Length; i++)
            {
                diceRolls[i] = Roll();
            }

            return diceRolls;
        }
    }
}
