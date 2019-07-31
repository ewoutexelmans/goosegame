﻿using System.Linq;
using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Players;

namespace GreenbeltGame.Core.Boards.Spaces
{
    public class GooseSpace : Space, IMovePlayerSpace
    {
        public int OldLocation { get; set; }

        public override void ApplyRules(Player player)
        {
            OldLocation = player.Location;
            MovePlayer(player);
            player.UpdateTurnInfo(OldLocation);
            player.IsTraveling = true;
        }

        public void MovePlayer(Player player)
        {
            player.Move(player.DiceRolls.Sum());
        }
    }
}
