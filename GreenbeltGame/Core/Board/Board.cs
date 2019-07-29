using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenbeltGame.Core.Board
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
