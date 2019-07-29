using System;

namespace GreenbeltGame.Infrastructure
{
    public class Dice
    {
        private readonly Random _random;
        public Dice()
        {
            _random = new Random();
        }
        public int Roll()
        {
            return _random.Next(1, 7);
        }

        public int[] RollMultiple(int numberOfDice)
        {
            var diceRolls = new int[numberOfDice];
            for (int i = 0; i < diceRolls.Length; i++)
            {
                diceRolls[i] = Roll();
            }
            return diceRolls;
        }
    }
}
