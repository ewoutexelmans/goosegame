namespace GreenbeltGame.Core.Pieces
{
    public class Piece
    {
        public int Location { get; set; }

        public Piece(int location)
        {
            Location = location;
        }

        public void Move(int diceRoll)
        {
            Location += diceRoll;
        }
    }
}
