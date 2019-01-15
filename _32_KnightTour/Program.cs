using System;
using _32_KnightTour.Properties;

namespace _32_KnightTour
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var board = new Board();
            board.PopulateArray(4, 5);
            board.DisplayBoard();
        }
    }
}
