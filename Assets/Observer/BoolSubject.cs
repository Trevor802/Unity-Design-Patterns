namespace ObserverPattern
{
    public class BoolSubject : Subject
    {
        private bool state;

        public bool State
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
