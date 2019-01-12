using UnityEngine;
using Bridge;

public class BridgeClient : MonoBehaviour
{
    private void OnEnable()
    {
        Abstraction abstraction = new RefinedAbstraction();
        abstraction.Implementor = new ConcreteImplementorA();
        abstraction.Operate();

        abstraction.Implementor = new ConcreteImplementorB();
        abstraction.Operate();
    }
}
