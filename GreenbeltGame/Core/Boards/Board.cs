using System.Collections.Generic;

namespace GreenbeltGame.Core.Boards
{
    public class Board
    {
        public List<Space> Spaces { get; private set; }

        public Board(List<Space> spaces)
        {
            Spaces = spaces;
        }
    }
}
