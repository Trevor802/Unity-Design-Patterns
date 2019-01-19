using UnityEngine;
using StrategyPattern;

public class StrategyClient : MonoBehaviour
{
    private void OnEnable()
    {
        var c = new Composition(new SimpleCompositor());
        c.Operation();
        c = new Composition(new ComplexCompositor());
        c.Operation();
    }
}
