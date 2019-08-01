using System.Linq;

namespace GreenbeltGame.Core.Pieces
{
    public class Piece
    {
        private readonly int _endLocation;
        private readonly int _startLocation;
        public int[] DiceRolls { get; set; }
        public int Location { get; set; }
        public bool HasWon { get; set; }
        public bool MovingForward { get; set; }
        public string TurnInfo { get; set; }
        public bool IsTraveling { get; set; }
        public int SkipTurnCount { get; set; }

        public Piece(int start, int destination)
        {
            _endLocation = destination;
            _startLocation = Location = start;
            MovingForward = true;
        }

        private void UpdateLocation(int numberOfSpaces)
        {
            if (MovingForward) Location += numberOfSpaces;
            else Location -= numberOfSpaces;
            if (Location < _startLocation) Location = _startLocation;
        }

        public void Move(int numberOfSpaces)
        {
            if (MovingForward && Location + DiceRolls.Sum() > _endLocation)
            {
                MovingForward = false;
                UpdateLocation(2 * Location - 2 * _endLocation + DiceRolls.Sum());
                return;
            }
            UpdateLocation(numberOfSpaces);
        }

        public void BackToStart()
        {
            Location = _startLocation;
        }

        public bool IsSkipped()
        {
            var result = false;
            if (SkipTurnCount > 0)
            {
                result = true;
                SkipTurnCount--;
            }
            if (SkipTurnCount < 0)
            {
                result = true;
            }
            return result;
        }

        public void UpdateTurnInfo()
        {

            InitMoveTurnInfo(Location);
        }

        public void UpdateTurnInfo(int oldLocation)
        {
            InitMoveTurnInfo(oldLocation);
            TurnInfo += $"->S{Location}";
        }

        private void InitMoveTurnInfo(int location)
        {
            if (!IsTraveling) TurnInfo = $"{DiceRolls[0]}+{DiceRolls[1]}: S{location}";
        }

        public void UpdateSkipTurnInfo()
        {
            TurnInfo = $"/ : S{Location}";
        }
    }
}
