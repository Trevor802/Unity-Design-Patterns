namespace ObserverPattern
{
    public class FloatSubject : Subject
    {
        private float state;

        public float State
        {
            get
            {
                return state;
            }
            set
            {
                if (value != State)
                {
                    state = value;
                    Notify();
                }
            }
        }
    }
}
