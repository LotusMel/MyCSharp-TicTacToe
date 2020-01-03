using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.ConsoleApp.Models;

namespace TicTacToe.ConsoleApp
{
    public class GameBoardRenderer
    {
        public static void Render(GameBoard protoBoard)
        {
            RenderTopBar(protoBoard);
            for (var r = 0; r < protoBoard.Grid.Rows; r++)
            {
                RenderRowLine(protoBoard, r, 0);
                RenderRowLine(protoBoard, r, 1);
                RenderRowLine(protoBoard, r, 2);

            }

           

        }

        private static void RenderRowLine(GameBoard protoBoard, int row, int line)
        {
            for (int sub = 0; sub < protoBoard.Grid.Columns; sub++)
            {
                if (line == 2)
                {
                    Console.Write("___|");

                }
                else if (line == 1)
                {
                    Console.Write(" ");
                    var cell = protoBoard.Grid.Cells.Find(x => x.Row == row && x.Col == sub);

                    if (!string.IsNullOrWhiteSpace(cell.Marker))
                    {
                        Console.Write(cell.Marker);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" |");
                }
                else 
                {
                    Console.Write("   |");
                }
            }
            Console.WriteLine();
            
        }

        private static void RenderTopBar(GameBoard protoBoard)
        {
            Console.Write("");
            for (int col = 0; col < protoBoard.Grid.Columns; col++)
            {
                Console.Write("____");
            }
            Console.WriteLine();
        }
    }
}
