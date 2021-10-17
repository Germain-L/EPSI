using System;

namespace RPS.Players
{
    public class User : Player
    {
        public override void Play()
        {
            int choice = -1;

            Console.Write("1) Rock, 2) Paper, 3) Scissors ? : ");
            choice = int.Parse(Console.ReadLine()) - 1;

            while (choice < 0 || choice > 3)
            {
                Console.WriteLine("Please only enter 1 , 2 or 3");
                choice = int.Parse(Console.ReadLine()) - 1;
            }


            CurrentItem = new Item(choice);
        }

        public override string ToString() => "You";
    }
}