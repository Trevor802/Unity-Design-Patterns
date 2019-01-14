namespace FlyweightPattern
{
    public abstract class Flyweight
    {
        protected char symbol;

        public Flyweight(char symbol)
        {
            this.symbol = symbol;
        }

        public abstract void Operation(string message);
    }
}