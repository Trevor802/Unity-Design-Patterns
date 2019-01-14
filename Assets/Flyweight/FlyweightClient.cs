using UnityEngine;
using FlyweightPattern;

public class FlyweightClient : MonoBehaviour
{
    public string Document;

    private void OnEnable()
    {
        var flyweightFactory = new FlyweightFactory();
        char[] chars = Document.ToCharArray();
        int extrinsicIndex = 0;
        foreach (var c in chars)
        {
            var flyweight = flyweightFactory.GetFlyweight(c);
            flyweight.Operation(extrinsicIndex.ToString());
            extrinsicIndex++;
        }
    }
}
