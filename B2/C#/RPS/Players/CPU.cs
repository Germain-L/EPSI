using System;

namespace RPS.Players
{
    public class CPU : Player
    {
        private readonly Random _random = new Random();
        
        public override void Play()
        {
            int choice = _random.Next(3);
            CurrentItem = new Item(choice);
        }

        public override string ToString() => "CPU";
    }
    
    
}