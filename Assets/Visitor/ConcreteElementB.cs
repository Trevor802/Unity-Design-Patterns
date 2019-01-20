namespace VisitorPattern
{
    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor v)
        {
            v.ConcreteElementB(this);
        }
    }
}