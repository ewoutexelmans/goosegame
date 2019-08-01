using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Pieces;

namespace GreenbeltGame.Core.Boards.Spaces
{
    public class BridgeSpace : Space, IMovePieceSpace
    {
        public int OldLocation { get; set; }

        public override void ApplyRules(Piece piece)
        {
            piece.MovingForward = true;
            OldLocation = piece.Location;
            MovePiece(piece);
            piece.UpdateTurnInfo(OldLocation);
            piece.IsTraveling = true;
        }

        public void MovePiece(Piece piece)
        {
            piece.Location = 12;
        }
    }
}
