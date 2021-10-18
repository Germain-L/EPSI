namespace RPS.Players
{
    public abstract class Player
    {
        private Item _currentItem;
        private int _score;

        public Item CurrentItem
        {
            get => _currentItem;
            set => _currentItem = value;
        }

        public int Score
        {
            get => _score;
            set
            {
                _score = value;
            }
        }

        public abstract void Play();
    }
}