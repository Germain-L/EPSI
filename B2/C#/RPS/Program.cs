using System;
using RPS.Players;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to rock paper scissors !");

            while (true)
            {
                Game game = new Game();
                Player winner  = game.Play();
                
                Console.WriteLine($"{winner} wins\n");
            }
        }
    }
}