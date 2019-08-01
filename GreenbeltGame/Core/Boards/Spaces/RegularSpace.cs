using GreenbeltGame.Core.Pieces;

namespace GreenbeltGame.Core.Boards.Spaces
{
    public class RegularSpace : Space
    {
        public override void ApplyRules(Piece piece)
        {
            piece.MovingForward = true;
            piece.UpdateTurnInfo();
            piece.IsTraveling = false;
        }
    }
}
