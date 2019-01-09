using UnityEngine;

namespace FactoryMethod
{
    public class ConcreteProductA : Product
    {
        public ConcreteProductA()
        {
            Debug.Log("Created Concrete Product A");
        }
    }
}