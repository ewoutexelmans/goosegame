using GreenbeltGame.Core.Pieces;

namespace GreenbeltGame.Core.Interfaces
{
    public interface IMovePieceSpace
    {
        int OldLocation { get; set; }
        void MovePiece(Piece piece);
    }
}
