using UnityEngine;

namespace DecoratorPattern
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Debug.Log("Operation: Concrete Decorator A");
        }
    }
}