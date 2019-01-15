using System;
namespace _32_KnightTour.Properties
{
    public class Board
    {

        public const int size = 8;
        public const char boardSymbol = '.';
        public const char moveSymbol = 'X';
        private int[] _horizontal;
        private int[] _vertical;

        public Board()
        {
            _horizontal = new[] { 2, 1, -1, -2, -2, -1, 1, 2 };
            _vertical = new[] { -1, -2, -2, -1, 1, 2, 2, 1 };
            ChessBoard = new char[size, size];
        }

        public int[] Horizontal { get { return _horizontal; } }

        public int[] Vertical {  get { return _vertical; } }

        public char[,] ChessBoard { get; set; }

        public void DisplayBoard()
        {
            Console.Write(" ");
            for (int i = 65; i < size + 65; i++)
                Console.Write(Convert.ToChar(i));

            Console.WriteLine();

            for (int r = 0; r < size; r++)
            {
                Console.Write(r + 1);
                for (int c = 0; c < size; c++)
                {
                    Console.Write(ChessBoard[r, c]);
                }
                Console.WriteLine();
            }
        }

        public void PopulateArray(int curH, int curV)
        {
            for (int i = 0; i < size; i++)
            {
                for (int c = 0; c < size; c++)
                {
                    ChessBoard[i, c] = boardSymbol;
                }
            }
            ChessBoard[curH, curV] = moveSymbol;
        }



    }
}
