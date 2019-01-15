using System;
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
    }
}
