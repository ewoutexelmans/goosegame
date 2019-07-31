using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Players;

namespace GreenbeltGame.Core.Boards.Spaces
{
    public class WellSpace : Space, ISkipTurnSpace
    {
        public Player OldPlayer { get; set; }
        public override void ApplyRules(Player player)
        {
            player.MovingForward = true;
            SkipTurn(player);
            player.UpdateTurnInfo();
            player.IsTraveling = false;
        }

        public void SkipTurn(Player player)
        {
            player.SkipTurnCount = -1;
            if (OldPlayer == null)
            {
                OldPlayer = player;
                return;
            }
            if (player == OldPlayer) return;
            OldPlayer.SkipTurnCount = 0;
            OldPlayer = player;
        }
    }
}
