using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Players;

namespace GreenbeltGame.Core.Boards.Spaces
{
    public class DeathSpace : Space, IMovePlayerSpace
    {
        public int OldLocation { get; set; }

        public override void ApplyRules(Player player)
        {
            player.MovingForward = true;
            OldLocation = player.Location;
            MovePlayer(player);
            player.UpdateTurnInfo(OldLocation);
            player.IsTraveling = false;
        }

        public void MovePlayer(Player player)
        {
            player.BackToStart();
        }
    }
}