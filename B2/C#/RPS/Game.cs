using System;
using RPS.Players;

namespace RPS
{
    public class Game
    {
        private int[] _scores = new[] {0, 0};

        public Player Play()
        {
            User user = new User();

            CPU cpu = new CPU();

            while (_scores[0] < 3 || _scores[1] < 3)
            {
                user.Play();
                cpu.Play();

                Console.WriteLine($"\nYou played {user.CurrentItem} vs {cpu.CurrentItem}");

                int res = (3 + user.CurrentItem.Number - cpu.CurrentItem.Number) % 3;

                if (res == 0)
                {
                    Console.WriteLine("Draw");
                }

                else
                {
                    var roundWinner = res - 1;
                    if (user.CurrentItem.Number == roundWinner)
                    {
                        _scores[0]++;
                        Console.WriteLine("You win");
                    }
                    else
                    {
                        _scores[1]++;
                        Console.WriteLine("CPU wins");
                    }
                }
                Console.WriteLine();
            }

            return _scores[0] == 3 ? user : cpu;
        }
    }
}