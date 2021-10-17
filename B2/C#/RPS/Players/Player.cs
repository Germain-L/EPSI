namespace RPS.Players
{
    public abstract class Player
    {
        private Item _currentItem;

        public Item CurrentItem
        {
            get => _currentItem;
            set => _currentItem = value;
        }

        public abstract void Play();
    }
}