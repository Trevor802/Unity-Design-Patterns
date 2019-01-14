using UnityEngine;
using FacadePattern;

public class FacadeClient : MonoBehaviour
{
    private void OnEnable()
    {
        var facade = new Facade();
        facade.MethodA();
        facade.MethodB();
    }
}
