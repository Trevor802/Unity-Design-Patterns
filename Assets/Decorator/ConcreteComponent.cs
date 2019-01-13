using UnityEngine;

namespace DecoratorPattern
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Debug.Log("Operation: Concrete Component");
        }
    }
}