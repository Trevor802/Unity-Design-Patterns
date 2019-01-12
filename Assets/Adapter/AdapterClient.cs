using UnityEngine;
using Adapter;

public class AdapterClient : MonoBehaviour
{
    private void OnEnable()
    {
        Target target = new Adapter.Adapter();
        Debug.Log(target.GetString());
    }
}
