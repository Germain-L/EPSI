using System;

namespace Puissance4
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Connect4();

            do
            {
                Display(game);
                for (;;)
                {
                    Console.WriteLine($"Player {game.PlayerNumber} : Which column 1-{game.ColCount} ?");

                    var turn = Console.ReadLine();
                    int column;
                    
                    // check if column is within ColCout bounds
                    if (int.TryParse(turn, out column) && (column > 0 && column <= game.ColCount))
                    {
                        bool played = game.Play(column);
                        if (played) break;
                    }

                    Console.Error.WriteLine("Invalid play.");
                }
            } while (!game.Ended);

            Display(game);
            if (game.Winner == 0)
            {
                Console.WriteLine("Draw");
            }
            else
            {
                Console.WriteLine($"Player {game.Winner} wins.");
            }
        }

        private static void Display(Connect4 game)
        {
            for (int y = 0; y < game.LineCount; y++)
            {
                for (int x = 0; x < game.ColCount; x++)
                {
                    Console.Write($"| {game.GetPawn(x, y)} ");
                }

                Console.WriteLine("|");
                for (int x = 0; x < game.ColCount; x++)
                {
                    Console.Write($"+---");
                }

                Console.WriteLine("+");
            }

            for (int x = 0; x < game.ColCount; x++)
            {
                Console.Write($"  {x + 1} ");
            }

            Console.WriteLine();
        }
    }
}