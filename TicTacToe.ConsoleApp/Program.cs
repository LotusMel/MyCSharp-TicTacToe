using System;
using System.Collections.Generic;
using TicTacToe.ConsoleApp.Models;

namespace TicTacToe.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe");
            Console.ReadLine();

            var protoBoard= CreateGameBoard();

            foreach (var cell in protoBoard.Grid.Cells) 
            {
                Console.WriteLine(string.Format("{0}:{1}", cell.Row, cell.Col));
            }

            Console.WriteLine("Press ENTER to begin.");
            Console.ReadLine();
        }

        public static GameBoard CreateGameBoard()
        {
            int cols = 0; int rows = 0;

            while (rows == 0)
            {
                Console.WriteLine("How many rows?: ");

                if (!int.TryParse(Console.ReadLine(), out rows))
                {
                    Console.WriteLine("Enter an integer value (Example: 3): ");
                }
            }

            while (cols == 0)
            {
                Console.WriteLine("How many columns?: ");

                if (!int.TryParse(Console.ReadLine(), out cols))
                {
                    Console.WriteLine("Enter an integer value (Example: 3): ");
                }
            }


            var protoBoard = new GameBoard();
            protoBoard.Generate(rows, cols);

            return protoBoard;
        }


    }
}
