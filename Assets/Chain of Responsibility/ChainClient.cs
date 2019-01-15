using UnityEngine;
using ChainPattern;

public class ChainClient : MonoBehaviour
{
    public int[] requests;

    private void OnEnable()
    {
        HelpHandler handlerA = new ConcreteHandlerA(null);
        HelpHandler handlerB = new ConcreteHandlerB(handlerA);
        HelpHandler handlerC = new ConcreteHandlerC(handlerB);

        foreach (var request in requests)
        {
            handlerC.HandleRequest(request);
        }
    }
}
