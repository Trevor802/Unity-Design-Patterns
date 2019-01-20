using UnityEngine;

namespace VisitorPattern
{
    public class ConcreteVisitorA : Visitor
    {
        public override void ConcreteElementA(Element element)
        {
            Debug.Log("VisitorA: Visit ConcreteA");
        }

        public override void ConcreteElementB(Element element)
        {
            Debug.Log("VisitorA: Visit ConcreteB");
        }
    }
}