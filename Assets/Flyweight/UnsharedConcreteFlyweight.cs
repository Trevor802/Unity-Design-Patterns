using UnityEngine;

namespace FlyweightPattern
{
    public class UnsharedConcreteFlyweight : Flyweight
    {
        protected int width, height;

        public UnsharedConcreteFlyweight(char symbol, int width, int height) 
            : base(symbol)
        {
            this.width = width;
            this.height = height;
        }

        public override void Operation(string eS)
        {
            Debug.Log(symbol + " Width: " + width + " Height: " + height + 
                " Extrinsic State: " + eS);
        }
    }
}
