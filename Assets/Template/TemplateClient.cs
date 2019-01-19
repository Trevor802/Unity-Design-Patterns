using UnityEngine;
using TemplatePattern;

public class TemplateClient : MonoBehaviour
{
    private void OnEnable()
    {
        new Concrete1().Operation();
        new Concrete2().Operation();
    }
}
