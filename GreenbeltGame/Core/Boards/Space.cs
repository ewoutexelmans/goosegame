using GreenbeltGame.Core.Pieces;

namespace GreenbeltGame.Core.Boards
{
    public abstract class Space
    {
        public abstract void ApplyRules(Piece piece);
    }
}
