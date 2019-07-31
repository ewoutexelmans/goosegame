using GreenbeltGame.Core.Players;

namespace GreenbeltGame.Core.Boards.Spaces
{
    public class RegularSpace : Space
    {
        public override void ApplyRules(Player player)
        {
            player.MovingForward = true;
            player.UpdateTurnInfo();
            player.IsTraveling = false;
        }
    }
}
