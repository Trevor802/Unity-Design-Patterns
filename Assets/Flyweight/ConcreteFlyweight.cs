using UnityEngine;

namespace FlyweightPattern
{
    public class ConcreteFlyweight : Flyweight
    {
        public ConcreteFlyweight(char symbol) : base(symbol)
        {
        }

        public override void Operation(string eS)
        {
            Debug.Log(symbol + " Extrinsic State: " + eS);
        }
    }
}