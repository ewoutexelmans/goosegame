using System.Collections.Generic;
using System.Linq;
using GreenbeltGame.Core.Boards;
using GreenbeltGame.Core.Boards.Spaces;
using GreenbeltGame.Core.GamePlays;
using GreenbeltGame.Core.Interfaces;
using GreenbeltGame.Core.Pieces;

namespace GreenbeltGame.Core
{
    public class GooseGame
    {
        private readonly IDice _dice;
        private readonly BoardFactory _boardFactory;
        private readonly IUserInterface _userInterface;

        public GooseGame(IDice dice, BoardFactory boardFactory, IUserInterface userInterface)
        {
            _dice = dice;
            _boardFactory = boardFactory;
            _userInterface = userInterface;
        }

        public void Create()
        {
            var numberOfPieces = _userInterface.GetNumberOfPieces(2, 4);
            var board = _boardFactory.CreateBoard();
            var pieces = new List<Piece>();
            for (var i = 0; i < numberOfPieces; i++)
            {
                pieces.Add(new Piece(0, board.Count - 1));
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
                if (!gamePlay.GameHasEnded)
                {
                    _userInterface.NextTurn(gamePlay.NumberOfTurns);
                }
            }
        }

        private void End(List<Piece> pieces)
        {
            _userInterface.EndMessage(pieces);
        }
    }
}
