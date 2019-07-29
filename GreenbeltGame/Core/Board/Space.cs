using GreenbeltGame.Core.Players;

namespace GreenbeltGame.Core.Board
{
    public class Space
    {
        public void ApplyRules(Player player)
        {
            player.MovingForward = true;
        }
    }
}
