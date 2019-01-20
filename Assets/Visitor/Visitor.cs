namespace VisitorPattern
{
    public abstract class Visitor
    {
        public abstract void ConcreteElementA(Element element);
        public abstract void ConcreteElementB(Element element);
    }
}