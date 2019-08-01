using System.Linq;
using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Pieces;

namespace GreenbeltGame.Core.Boards.Spaces
{
    public class GooseSpace : Space, IMovePieceSpace
    {
        public int OldLocation { get; set; }

        public override void ApplyRules(Piece piece)
        {
            OldLocation = piece.Location;
            MovePiece(piece);
            piece.UpdateTurnInfo(OldLocation);
            piece.IsTraveling = true;
        }

        public void MovePiece(Piece piece)
        {
            piece.Move(piece.DiceRolls.Sum());
        }
    }
}
