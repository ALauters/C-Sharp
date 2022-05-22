using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessboard
{
    internal class Cell
    {
        public int RowNum { get; set; }

        public int ColNum { get; set; }

        public bool Occupied { get; set; }

        public bool LegalNextMove { get; set; }

        public Cell(int rowNum, int colNum)
        {
            RowNum = rowNum;
            ColNum = colNum;
        }
    }
}
