namespace TemplatePattern
{
    public abstract class Abstract
    {
        public void Operation()
        {
            HookOperation();
        }

        protected abstract void HookOperation();
    }
}