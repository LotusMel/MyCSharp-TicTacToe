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

            PlayersReady(protoBoard);

            Console.WriteLine("Press ENTER to begin.");
            Console.ReadLine();
        }

        public static GameBoard CreateGameBoard()
        {
            int cols = MustBeANumber("How many columns?: ");
            int rows = MustBeANumber("How many rows?: ");

            var protoBoard = new GameBoard();
            protoBoard.Generate(rows, cols);

            return protoBoard;
        }

        public static void PlayersReady(GameBoard board)
        {
            var count = MustBeANumber("How many players?: ");

            for (int p = 0; p < count; p++)
            {
                Console.Write(string.Format("Name of player {0}: ", p + 1));
                var name = Console.ReadLine();
                var marker = "";
                while (string.IsNullOrWhiteSpace(marker))
                {
                    Console.Write(name + "'s marker: ");
                    marker = (Console.ReadKey().KeyChar).ToString();
                }
                Console.WriteLine();
                board.Players.Add(new Player { Name = name, Marker = marker });
            }
        }

        private static int MustBeANumber(string message)
        {
            int ans = 0;
            while (ans == 0)
            {
                Console.Write(message);

                if (!int.TryParse(Console.ReadLine(), out ans))
                {
                    Console.WriteLine("Enter an integer value (Example: 3): ");
                }
            }
            return ans;
        }

    }
}
