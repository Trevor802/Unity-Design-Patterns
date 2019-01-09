using UnityEngine;

namespace FactoryMethod
{
    public class ConcreteProductB : Product
    {
        public ConcreteProductB()
        {
            Debug.Log("Created Concrete Product B");
        }
    }
}