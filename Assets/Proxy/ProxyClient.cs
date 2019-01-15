using UnityEngine;
using ProxyPattern;

public class ProxyClient : MonoBehaviour
{
    private void OnEnable()
    {
        Proxy proxy = new Proxy();
        proxy.Request();
    }
}
