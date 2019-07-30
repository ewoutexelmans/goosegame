using System.Collections.Generic;
using GreenbeltGame.Core.Players;

namespace GreenbeltGame.Core.Interfaces
{
    public interface IUserInterface
    {
        void StartMessage(int numberOfPlayers);
        void TurnMessage(List<Player> players, int numberOfTurns);
        void NextTurn(int numberOfTurns);
        void EndMessage(List<Player> players);
    }
}