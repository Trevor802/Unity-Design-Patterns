namespace Singleton
{
    public class ConcreteSingleton : Singleton<ConcreteSingleton>
    {
        protected ConcreteSingleton() { }

        public string singletonMessage = "This is a concrete singleton.";
    }
}
