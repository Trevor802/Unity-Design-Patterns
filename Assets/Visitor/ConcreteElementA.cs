namespace VisitorPattern
{
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor v)
        {
            v.ConcreteElementA(this);
        }
    }
}