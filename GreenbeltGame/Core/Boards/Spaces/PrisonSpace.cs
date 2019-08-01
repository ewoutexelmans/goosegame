using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Pieces;

namespace GreenbeltGame.Core.Boards.Spaces
{
    public class PrisonSpace : Space, ISkipTurnSpace
    {
        public override void ApplyRules(Piece piece)
        {
            piece.MovingForward = true;
            SkipTurn(piece);
            piece.UpdateTurnInfo();
            piece.IsTraveling = false;
        }

        public void SkipTurn(Piece piece)
        {
            piece.SkipTurnCount = 3;
        }
    }
}
