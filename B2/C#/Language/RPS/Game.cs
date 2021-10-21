using System;
using RPS.Players;

namespace RPS
{
    public class Game
    {

        public Player Play()
        {
            User user = new User();

            CPU cpu = new CPU();

            while (user.Score < 3 || cpu.Score < 3)
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
                        user.Score++;
                        Console.WriteLine("You win");
                    }
                    else
                    {
                        cpu.Score++;
                        Console.WriteLine("CPU wins");
                    }
                }
                Console.WriteLine();
            }

            return user.Score > cpu.Score ? user : cpu;
        }
    }
}