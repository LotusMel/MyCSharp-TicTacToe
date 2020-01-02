using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.ConsoleApp.Models
{
    public class GameBoard
    {
        public string Message { get; set; }

        public Grid Grid { get; set; }

        public List<Player> Players { get; set; }

        public GameBoard()
        {
            Grid = new Grid(0, 0);
            Players = new List<Player>();
        }

        public void Generate(int rows, int cols)
        {
            Grid = new Grid(rows, cols);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    var cell = new GridCell();
                    cell.Row = r;
                    cell.Col = c;
                    //Grid.Cells = new List<GridCell>();
                    Grid.Cells.Add(cell);
                }
            }
        }
    }
}
