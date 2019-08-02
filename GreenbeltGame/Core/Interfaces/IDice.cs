namespace GreenbeltGame.Core.Interfaces
{
    public interface IDice
    {
        int Roll();
        int[] RollMultiple(int numberOfDice);
    }
}