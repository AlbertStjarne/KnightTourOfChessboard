using System;
using System.Linq;

namespace _32_KnightTour.Properties
{
    public class Knight
    {
        private Random _rand = new Random();
        private int _curH;
        private int _curV;
        private Board _board;
        private bool _isFullTour = false;
        private bool _isEndTour = false;
        private static int _bestScore = 0; //stores the most number of moves made in one tour so far
        private static int _tourCount = 0; //counts all incomplete tours
        private int _moveCounter;

        public Knight()
        {
            _board = new Board();

        }

        public void Move()
        {
            while(!_isFullTour)
            {
                _curH = _rand.Next(Board.size);
                _curV = _rand.Next(Board.size);

                _moveCounter = 1;
                _board.PopulateArray(_curH, _curV);
                _isEndTour = false;

                do
                {

                } while (!_isEndTour);
            }
        }

        public bool IsMoving()
        {
            int[] movesTaken = { 0, 0, 0, 0, 0, 0, 0, 0 };
            var allMovesUsed = false;

            while (!allMovesUsed)
            {
                var i = _rand.Next(8);
                if (movesTaken[i] == 0)
                {
                    var hMove = _curH + _board.Horizontal[i];
                    var vMove = _curV + _board.Vertical[i];

                    if (hMove >= 0 && hMove < Board.size && vMove >= 0 && vMove < Board.size && _board.ChessBoard[hMove, vMove] == Board.boardSymbol)
                    {
                        _curH = hMove;
                        _curV = vMove;
                        _board.ChessBoard[_curH, _curV] = Board.moveSymbol;
                        _moveCounter++;
                        return true;
                    }

                    movesTaken[i] = 1;

                }

                if (!movesTaken.Contains(0))
                    allMovesUsed = true;
            }

            _tourCount++;
            return false;
        }


    }
}
