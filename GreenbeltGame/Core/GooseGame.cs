using System.Collections.Generic;
using System.Linq;
using GreenbeltGame.Core.Boards;
using GreenbeltGame.Core.GamePlays;
using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Pieces;
using GreenbeltGame.Infrastructure;

namespace GreenbeltGame.Core
{
    public class GooseGame
    {
        private readonly Dice _dice;
        private readonly BoardFactory _boardFactory;
        private readonly IUserInterface _userInterface;

        public GooseGame(Dice dice, BoardFactory boardFactory, IUserInterface userInterface)
        {
            _dice = dice;
            _boardFactory = boardFactory;
            _userInterface = userInterface;
        }

        public void Create(int numberOfPieces)
        {
            if (numberOfPieces < 2 || numberOfPieces > 4)
            {
                _userInterface.PieceNumberErrorMessage();
                return;
            }
            var board = _boardFactory.CreateBoard();
            var pieces = new List<Piece>();
            for (var i = 0; i < numberOfPieces; i++)
            {
                pieces.Add(new Piece(board.IndexOf(board.First()),
                    board.IndexOf(board.Last())));
            }
            var gamePlay = new GamePlay(board, pieces, _dice);

            Start(numberOfPieces);
            GameLoop(gamePlay, pieces);
            End(pieces);
        }

        private void Start(int numberOfPieces)
        {
            _userInterface.StartMessage(numberOfPieces);

        }

        private void GameLoop(GamePlay gamePlay, List<Piece> pieces)
        {
            while (!gamePlay.GameHasEnded)
            {
                gamePlay.TakeTurn();
                _userInterface.TurnMessage(pieces, gamePlay.NumberOfTurns);
                if (!gamePlay.GameHasEnded) _userInterface.NextTurn(gamePlay.NumberOfTurns);
            }
        }

        private void End(List<Piece> pieces)
        {
            _userInterface.EndMessage(pieces);
        }
    }
}
