using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.ConsoleApp.Models
{
    public class Grid
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public List<GridCell> Cells { get; set; }

        public Grid(int rows, int cols)
        {
            Rows = rows;
            Columns = cols;
            Cells = new List<GridCell>();
        }
    }
}
