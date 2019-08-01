using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Pieces;

namespace GreenbeltGame.Core.Boards.Spaces
{
    public class DeathSpace : Space, IMovePieceSpace
    {
        public int OldLocation { get; set; }

        public override void ApplyRules(Piece piece)
        {
            piece.MovingForward = true;
            OldLocation = piece.Location;
            MovePiece(piece);
            piece.UpdateTurnInfo(OldLocation);
            piece.IsTraveling = false;
        }

        public void MovePiece(Piece piece)
        {
            piece.BackToStart();
        }
    }
}