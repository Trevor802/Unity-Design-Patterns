using UnityEngine;
using ObserverPattern;

public class ObserverClient : MonoBehaviour
{
    private void OnEnable()
    {
        var bS = new BoolSubject();
        var iS = new IntSubject();
        var fS = new FloatSubject();

        var oA = new ConcreteObserverA(iS, bS);
        var oB = new ConcreteObserverB(iS, bS, fS);

        bS.AddObserver(oA);
        bS.AddObserver(oB);
        iS.AddObserver(oA);
        iS.AddObserver(oB);
        fS.AddObserver(oA);
        fS.AddObserver(oB);

        bS.State = false; // false won't invoke State's Set function
        iS.State = 1;
        fS.State = 0.5f;
    }
}
