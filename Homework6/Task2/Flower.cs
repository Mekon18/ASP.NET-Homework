namespace Task2
{
    class Flower
    {
        private uint _price;

        public Flower(uint price)
        {
            _price = price;
        }
        public Flower() : this(10)
        {
        }

        public virtual uint GetPrice()
        {
            return _price;
        }
    }
}
