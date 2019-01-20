using UnityEngine;

namespace VisitorPattern
{
    public class ConcreteVisitorB : Visitor
    {
        public override void ConcreteElementA(Element element)
        {
            Debug.Log("VisitorB: Visit ConcreteA");
        }

        public override void ConcreteElementB(Element element)
        {
            Debug.Log("VisitorB: Visit ConcreteB");
        }
    }
}