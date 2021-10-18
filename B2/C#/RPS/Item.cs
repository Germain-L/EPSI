using System;

namespace RPS
{
    public class Item
    {
        private int _number;

        public override string ToString() => Name;

        public Item(int number)
        {
            _number = number;
        }

        private string Name
        {
            get => "Rock,Paper,Scissors".Split(",")[Number];
        }

        public int Number
        {
            get => _number;
            set
            {
                switch (value)
                {
                    case < 0:
                        throw new ArgumentOutOfRangeException("value", "Too low");
                    case >= 3:
                        throw new ArgumentOutOfRangeException("value", "Too high");
                    default:
                        _number = value;
                        break;
                }
            }
        }
    }
}