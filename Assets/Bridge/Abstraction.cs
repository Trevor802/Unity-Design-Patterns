namespace Bridge
{
    public class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor
        {
            set
            {
                implementor = value;
            }
        }

        public virtual void Operate()
        {
            implementor.Operate();
        }
    }
}