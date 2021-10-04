using System;

namespace Devin
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int guess = 50;
            string input = "";
            int max = 100;
            int min = 0;
            int range = 50;
            bool found = false;


            while (!found)
            {
                Console.WriteLine($"Is your number {guess} ? (y/n)");

                input = Console.ReadLine();
                if (input == "n")
                {
                    do
                    {
                        Console.WriteLine("Is your number higher or lower ? (h/l)");
                        input = Console.ReadLine();
                    } while (input != "h" && input != "l");

                    switch (input)
                    {
                        case "h":
                            min = guess;
                            range = max - min;
                            guess += range / 2;
                            break;
                        case "l":
                            max = guess;
                            range = max - min;
                            guess -= range / 2;
                            break;
                    }
                }
                else
                {
                    found = true;
                }
            }

            Console.WriteLine($"Found your number, it's {guess}");
        }
    }
}