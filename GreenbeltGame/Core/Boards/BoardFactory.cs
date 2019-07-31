using System;
using System.Collections.Generic;
using GreenbeltGame.Core.Model;

namespace GreenbeltGame.Core.Boards
{
    public class BoardFactory
    {
        private readonly List<SpaceType> _spaceTypes;

        public BoardFactory(List<SpaceType> spaceTypes)
        {
            _spaceTypes = spaceTypes;
        }

        public List<Space> CreateBoard()
        {
            var list = new List<Space>();
            foreach (var type in _spaceTypes)
            {
                var item = (Space)Activator.CreateInstance(
                    Type.GetType($"GreenbeltGame.Core.Boards.Spaces.{type}Space"));
                list.Add(item);
            }
            return list;
        }
    }
}
