﻿using System.Collections.Generic;
using GreenbeltGame.Core.Pieces;

namespace GreenbeltGame.Core.Interfaces
{
    public interface IUserInterface
    {
        int GetNumberOfPieces(int lowerLimit, int upperLimit);
        void StartMessage(int numberOfPieces);
        void TurnMessage(List<Piece> pieces, int numberOfTurns);
        void NextTurn(int numberOfTurns);
        void EndMessage(List<Piece> pieces);
    }
}