using UnityEngine;
using IteratorPattern;

public class IteratorClient : MonoBehaviour
{
    public string Elements;

    private void OnEnable()
    {
        ConcreteList<char> list = new ConcreteList<char>();
        foreach (var c in Elements.ToCharArray())
        {
            list.Add(c);
        }
        var iterator = list.CreateIterator();
        for (iterator.First(); !iterator.IsDone(); iterator.Next())
        {
            Debug.Log(iterator.CurrentItem());
        }
    }
}
