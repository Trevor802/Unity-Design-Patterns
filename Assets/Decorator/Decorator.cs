namespace DecoratorPattern
{
    public class Decorator : Component
    {
        private Component component;

        protected Decorator(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            component?.Operation();
        }
    }
}