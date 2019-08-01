using System.Collections.Generic;
using System.Linq;
using GreenbeltGame.Core.Boards;
using GreenbeltGame.Core.Pieces;
using GreenbeltGame.Infrastructure;

namespace GreenbeltGame.Core.GamePlays
{
    public class GamePlay
    {
        private readonly List<Space> _board;
        private readonly List<Piece> _pieces;
        private readonly Dice _dice;

        public int NumberOfTurns { get; private set; }
        public bool GameHasEnded { get; private set; }

        public GamePlay(List<Space> board, List<Piece> pieces, Dice dice)
        {
            _board = board;
            _pieces = pieces;
            _dice = dice;
        }
        public void TakeTurn()
        {
            NumberOfTurns++;
            foreach (var piece in _pieces)
            {
                if (piece.IsSkipped())
                {
                    piece.UpdateSkipTurnInfo();
                    continue;
                }
                DiceRoll(piece);
                CheckPieceLocation(piece);
                if (!piece.HasWon) continue;
                if (GameHasEnded) piece.HasWon = false;
                else GameHasEnded = true;
            }
        }

        private void CheckPieceLocation(Piece piece)
        {
            while (true)
            {
                _board[piece.Location].ApplyRules(piece);
                if (piece.IsTraveling)
                {
                    continue;
                }

                break;
            }
        }

        private void DiceRoll(Piece piece)
        {
            var diceRolls = piece.DiceRolls = _dice.RollMultiple(2);
            if (NumberOfTurns == 1)
            {
                if (diceRolls.Contains(4) && diceRolls.Contains(5))
                {
                    piece.Move(26);
                    return;
                }

                if (diceRolls.Contains(3) && diceRolls.Contains(6))
                {
                    piece.Move(53);
                    return;
                }
            }
            piece.Move(diceRolls.Sum());
        }
    }
}
