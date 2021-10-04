using System;

#nullable enable
namespace Devin
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter min and max values");


                Console.Write("Min: ");
                string? minStr = Console.ReadLine();
                // * Gotten from https://stackoverflow.com/a/52969952/13140504 to convert null string to int
                int min = int.TryParse(minStr, out var minTemp) ? minTemp : default;


                Console.Write("Max: ");
                var maxStr = Console.ReadLine();
                // * Gotten from https://stackoverflow.com/a/52969952/13140504 to convert null string to int
                int max = int.TryParse(maxStr, out var maxTemp) ? maxTemp : default;

                
                // initialise new Game with given values
                var game = new Game(min, max);
                
                Console.WriteLine("Press any key to play again, enter to quit\n");
                string? input = Console.ReadLine();
                
                // check if nothing has been entered
                // not sure if input can be null when nothing is entered
                // so i added the check in case
                if (input! == "" || input is null) return;
            }
        }
    }

    internal class Game
    {
        // private variables
        private int _max;
        private int _min;
        private int _range;
        private int _guess;
        private char _input;
        private bool _found;

        // Construct Game class with given values
        public Game(int min, int max)
        {
            _min = min;
            _max = max;
            _range = max - min;
            
            // always guess in the middle of the range
            _guess = _range / 2;
            
            // start the game
            Play();
        }

        private void Play()
        {
            // carry on while guess is not found
            while (!_found)
            {
                Round();
            }
            Console.WriteLine();
            Console.WriteLine($"Game is finished ! Your number was {_guess}");
        }

        private void Round()
        {
            // get user char of y or n
            Console.WriteLine($"\nIs your number {_guess} ? ( y / n )");
            _input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // tell the user that their input is not recognized
            while (_input != 'y' && _input != 'n')
            {
                Console.WriteLine($"Please enter either 'y' or 'n'");
                _input = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }


            switch (_input)
            {
                case 'y':
                    _found = true;
                    break;
                case 'n':
                    // ask user if their number is higher or lower
                    HigherOrLower();
                    
                    switch (_input)
                    {
                        case 'h':

                            CalculateHigherGuess();
                            break;
                        case 'l':
                            CalculateLowerGuess();
                            break;
                    }
                    
                    break;
            }
        }

        private void HigherOrLower()
        {
            // get user char of h or l
            Console.WriteLine($"\nIs your number higher or lower");
            _input = Console.ReadKey().KeyChar;
            Console.WriteLine();
        
            // tell the user that their input is not recognized
            while (_input != 'h' && _input != 'l')
            {
                Console.WriteLine($"Please enter either 'h' or 'l'");
                _input = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }

        private void CalculateHigherGuess()
        {
            _min = _guess;
            _range = _max - _min;
            _guess += _range / 2;
        }

        private void CalculateLowerGuess()
        {
            _max = _guess;
            _range = _max - _min;
            _guess -= _range / 2;
        }
    }
}