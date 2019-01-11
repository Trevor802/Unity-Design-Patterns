using UnityEngine;
using Singleton;

public class SingletonClient : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log(ConcreteSingleton.Instance.singletonMessage);
    }

}
