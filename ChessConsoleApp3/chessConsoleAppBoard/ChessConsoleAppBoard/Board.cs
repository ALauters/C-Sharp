using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsoleAppBoard
{
    public class Board
    {
        // size of board usually 8x8
        public int Size { get; set; }

        public Cell[,] theGrid { get; set; }

        public Board(int size)
        {
            Size = size;

            theGrid = new Cell[Size, Size];

            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    theGrid[row, col] = new Cell(row, col);
                }
            }
        }

        public void ShowNextLegalMoves(Cell currentCell, string chessPicee)
        {
            // clear all previous legal moves from board
            clearLegalMoves();
            // clear all occupied spots from board
            clearOccupied();



            switch (chessPicee)
            {
                case ("pawn"):
                    Console.WriteLine("this isnt implemented yet");
                    break;

                case ("rook"):
                    cardinals(currentCell);
                    break;

                case ("knight"):
                    isSafe(currentCell, 2, 1);
                    isSafe(currentCell, 2, -1);
                    isSafe(currentCell, -2, 1);
                    isSafe(currentCell, -2, -1);

                    isSafe(currentCell, 1, 2);
                    isSafe(currentCell, -1, 2);
                    isSafe(currentCell, 1, -2);
                    isSafe(currentCell, -1, -2);

                    break;

                case ("bishop"):
                    diagonals(currentCell);
                    break;

                case ("queen"):
                    diagonals(currentCell);
                    cardinals(currentCell);
                    break;

                case ("king"):
                    isSafe(currentCell, -1, -1);
                    isSafe(currentCell, -1, 0);
                    isSafe(currentCell, -1, 1);
                    isSafe(currentCell, 0, -1);
                    isSafe(currentCell, 0, 1);
                    isSafe(currentCell, 1, -1);
                    isSafe(currentCell, 1, 0);
                    isSafe(currentCell, 1, 1);
                    break;
            }
            theGrid[currentCell.RowNum, currentCell.ColNum].Occupied = true;
        }

        private bool isSafe(Cell cell, int rowAdjust, int colAdjust)
        {
            try
            {
                theGrid[cell.RowNum + rowAdjust, cell.ColNum + colAdjust].LegalNextMove = true;
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void cardinals(Cell cell)
        {
            // up (negative in a grid)
            int up = -1;
            while (isSafe(cell, up, 0))
            {
                up--;
            }

            // down
            int down = 1;
            while (isSafe(cell, down, 0))
            {
                down++;
            }

            // left
            int left = -1;
            while (isSafe(cell, 0, left))
            {
                left--;
            }

            // right
            int right = 1;
            while (isSafe(cell, 0, right))
            {
                right++;
            }
        }

        private void diagonals(Cell cell)
        {

            // up (negative in a grid)
            int upLeft = -1;
            while (isSafe(cell, upLeft, upLeft))
            {
                upLeft--;
            }

            // down
            int upRight = 1;
            while (isSafe(cell, -upRight, upRight))
            {
                upRight++;
            }

            // left
            int downLeft = 1;
            while (isSafe(cell, downLeft, -downLeft))
            {
                downLeft++;
            }

            // right
            int downRight = 1;
            while (isSafe(cell, downRight, downRight))
            {
                downRight++;
            }
        }



        public void clearOccupied()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    theGrid[row, col].Occupied = false;
                }
            }
        }

        public void clearLegalMoves()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    theGrid[row, col].LegalNextMove = false;
                }
            }
        }



    }
}
