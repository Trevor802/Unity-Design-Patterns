using UnityEngine;
using VisitorPattern;

public class VisitorClient : MonoBehaviour
{
    private void OnEnable()
    {
        var visitorA = new ConcreteVisitorA();
        var visitorB = new ConcreteVisitorB();
        var elementA = new ConcreteElementA();
        var elementB = new ConcreteElementB();
        elementA.Accept(visitorA);
        elementA.Accept(visitorB);
        elementB.Accept(visitorA);
        elementB.Accept(visitorB);
    }
}
