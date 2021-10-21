using System;
using System.Linq;

namespace RPS.Players
{
    public class User : Player
    {
        public override void Play()
        {
            int choice;

            var availableChoices = new int[] {0, 1, 2};


            do Console.WriteLine("1) Rock, 2) Paper, 3) Scissors ? : ");
            while (!int.TryParse(Console.ReadLine(), out choice));


            CurrentItem = new Item(choice - 1);
        }

        public override string ToString() => "You";
    }
}