using System;
using ChessConsoleAppBoard;

namespace ChessConsoleApp3
{
    class Program
    {
        static Board myBoard = new Board(8);
        static String pieceName = "";

        static void Main(string[] args)
        {
            Cell currentCell = setCurrentCell();
            currentCell.Occupied = true;

            myBoard.ShowNextLegalMoves(currentCell, pieceName);
            printBoard(myBoard);

        }

        private static Cell setCurrentCell()
        {
            // get x and y from user and return cell from grid

            // I wouldlike to make this work with actual chess board leters and numbers like A8
            Console.WriteLine("Enter the row number 0-7");
            int currentRow = int.Parse(Console.ReadLine());
            if (currentRow < 0 || currentRow > 7)
            {
                Console.WriteLine("Incorrect value, using default of 3");
                currentRow = 3;
            }

            Console.WriteLine("Enter the collumn number 0-7");
            int currentCol = int.Parse(Console.ReadLine());
            if (currentCol < 0 || currentRow > 7)
            {
                Console.WriteLine("Incorrect value, using default of 3");
                currentCol = 3;
            }

            Console.WriteLine("What Piece Do You Want To Place?\nKing\nQueen\nBishop\nKnight\nRook\nPawn");
            pieceName = Console.ReadLine().ToLower();

            if (pieceName != "king" && pieceName != "queen" && pieceName != "bishop" && pieceName != "rook" && pieceName != "pawn")
            {
                Console.WriteLine($"Incorrect input of {pieceName}, using default of Queen");
                pieceName = "queen";
            }
            return myBoard.theGrid[currentRow, currentCol];
        }

        private static void printBoard(Board myBoard)
        {
            // prints the board
            // X is piece location
            // + is legal move

            for (int row = 0; row < myBoard.Size; row++)
            {
                Console.WriteLine("+---+---+---+---+---+---+---+---+");

                for (int col = 0; col < myBoard.Size; col++)
                {
                    Cell c = myBoard.theGrid[row, col];

                    if (c.Occupied)
                    {
                        Console.Write("| X ");
                    }
                    else if (c.LegalNextMove)
                    {
                        Console.Write("| + ");
                    }
                    else
                    {
                        Console.Write("|   ");
                    }

                }
                Console.Write("|\n");

            }
            Console.WriteLine("+---+---+---+---+---+---+---+---+");
        }
    }
}
