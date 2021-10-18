using System;
using RPS.Players;


namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to rock paper scissors !");
            bool playAgain = true;
            Game game;
            while (playAgain)
            {
                game = new Game();
                
                Player winner  = game.Play();
                
                Console.WriteLine($"{winner} wins\n");
                
                Console.WriteLine("Do you wish to play again ? (Y/n)");
                
                var choice = Console.ReadLine().ToLower();
                
                if (choice == "N")
                {
                    playAgain = false;
                }
            }
            
            Console.WriteLine("Goodbye :D");
        }
    }
}