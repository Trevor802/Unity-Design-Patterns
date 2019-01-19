namespace StatePattern
{
    public abstract class State
    {
        protected Character character;
        protected string stateName;

        public abstract void Tick();

        public virtual void OnStateEnter() { }
        public virtual void OnStateExit() { }

        public State(Character character)
        {
            this.character = character;
        }

        public string GetName()
        {
            return stateName;
        }
    }
}

