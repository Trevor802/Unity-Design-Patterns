using UnityEngine;
using System.Collections;
using SubclassSandbox;

public class SubclassSandboxClient : MonoBehaviour
{
    private Superclass subclass;

    private void Awake()
    {
        subclass = new Subclass1(gameObject);
    }

    private void Start()
    {
        subclass.Activate();
        subclass = new Subclass2(gameObject);
        StartCoroutine(DelayTrigger());
    }

    private IEnumerator DelayTrigger()
    {
        yield return new WaitForSeconds(2);
        subclass.Activate();
    }
}
