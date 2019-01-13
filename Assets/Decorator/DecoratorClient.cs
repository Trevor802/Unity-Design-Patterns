using UnityEngine;
using DecoratorPattern;

public class DecoratorClient : MonoBehaviour
{
    private void OnEnable()
    {
        var concreteComponent = new ConcreteComponent();
        var decoratorA = new ConcreteDecoratorA(concreteComponent);
        var decoratorB = new ConcreteDecoratorB(decoratorA);

        decoratorB.Operation();
    }
}
