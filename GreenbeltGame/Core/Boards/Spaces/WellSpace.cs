using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Pieces;

namespace GreenbeltGame.Core.Boards.Spaces
{
    public class WellSpace : Space, ISkipTurnSpace
    {
        private Piece _oldPiece;
        public override void ApplyRules(Piece piece)
        {
            piece.MovingForward = true;
            SkipTurn(piece);
            piece.UpdateTurnInfo();
            piece.IsTraveling = false;
        }

        public void SkipTurn(Piece piece)
        {
            piece.SkipTurnCount = -1;
            if (_oldPiece == null)
            {
                _oldPiece = piece;
                return;
            }
            if (piece == _oldPiece) return;
            _oldPiece.SkipTurnCount = 0;
            _oldPiece = piece;
        }
    }
}
