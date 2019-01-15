namespace ChainPattern
{
    public abstract class HelpHandler
    {
        protected HelpHandler successor;

        public HelpHandler(HelpHandler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);

        protected abstract bool HasHelp(int request);
    }
}