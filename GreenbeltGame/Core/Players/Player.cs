namespace GreenbeltGame.Core.Players
{
    public class Player
    {
        public int[] DiceRolls { get; set; }
        public int Location { get; set; }
        public bool HasWon { get; set; }
        public bool MovingForward { get; set; }
        public string TurnInfo { get; private set; }

        public Player(int location)
        {
            Location = location;
            HasWon = false;
            MovingForward = true;
        }

        public void DiceRollMove(int numberOfSpaces)
        {
            Move(numberOfSpaces);
            UpdateTurnInfo();
        }

        private void Move(int numberOfSpaces)
        {
            if (MovingForward) Location += numberOfSpaces;
            else Location -= numberOfSpaces;
        }

        private void UpdateTurnInfo()
        {
            TurnInfo = $"{DiceRolls[0]}+{DiceRolls[1]}: S{Location}";
        }
    }
}
