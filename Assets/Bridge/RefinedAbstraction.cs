namespace Bridge
{
    public class RefinedAbstraction : Abstraction
    {
        public override void Operate()
        {
            implementor.Operate();
        }
    }
}