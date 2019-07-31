using GreenbeltGame.Core.Players;

namespace GreenbeltGame.Core.Boards.Spaces
{
    public class EndSpace : Space
    {
        public override void ApplyRules(Player player)
        {
            player.HasWon = true;
            player.UpdateTurnInfo();
            player.IsTraveling = false;
        }
    }
}
