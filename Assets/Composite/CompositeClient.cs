using UnityEngine;
using CompositePattern;

public class CompositeClient : MonoBehaviour
{
    private void OnEnable()
    {
        var root = new Composite("root");
        var leaf = new Leaf("leaf 1");
        var component = new Composite("component 1");
        root.Add(leaf);
        root.Add(component);
        component.Add(new Leaf("leaf 3"));
        leaf = new Leaf("leaf 4");
        component.Add(leaf);
        component.Remove(leaf);

        root.Display(1);
    }
}
