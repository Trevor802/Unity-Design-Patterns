namespace Adapter
{
    public class Adapter : Target
    {
        private Adaptee adaptee;

        public override string GetString()
        {
            return adaptee == null ? new Adaptee().MakeString() : adaptee.MakeString();
        }
    }
}