using UnityEngine;

namespace DecoratorPattern
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Debug.Log("Operation: Concrete Decorator B");
        }
    }
}