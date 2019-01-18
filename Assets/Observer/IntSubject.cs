namespace ObserverPattern
{
    public class IntSubject : Subject
    {
        private int state;

        public int State
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
