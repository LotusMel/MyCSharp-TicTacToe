using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.ConsoleApp.Models
{
    public class GridCell
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string Marker { get; set; }
    }
}
