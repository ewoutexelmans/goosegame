using GreenbeltGame.Core.Pieces;

namespace GreenbeltGame.Core.Boards.Spaces
{
    public class EndSpace : Space
    {
        public override void ApplyRules(Piece piece)
        {
            piece.HasWon = true;
            piece.UpdateTurnInfo();
            piece.IsTraveling = false;
        }
    }
}
