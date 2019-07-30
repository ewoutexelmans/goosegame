using GreenbeltGame.Core.Players;

namespace GreenbeltGame.Core.Boards
{
    public class Space
    {
        public void ApplyRules(Player player)
        {
            player.MovingForward = true;
        }
    }
}
