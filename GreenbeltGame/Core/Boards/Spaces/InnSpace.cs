using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Players;

namespace GreenbeltGame.Core.Boards.Spaces
{
    public class InnSpace : Space, ISkipTurnSpace
    {
        public override void ApplyRules(Player player)
        {
            player.MovingForward = true;
            SkipTurn(player);
            player.UpdateTurnInfo();
            player.IsTraveling = false;
        }

        public void SkipTurn(Player player)
        {
            player.SkipTurnCount = 1;
        }
    }
}
