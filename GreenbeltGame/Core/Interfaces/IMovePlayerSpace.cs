using GreenbeltGame.Core.Players;

namespace GreenbeltGame.Core.Interfaces
{
    public interface IMovePlayerSpace
    {
        int OldLocation { get; set; }
        void MovePlayer(Player player);
    }
}
