using UnityEngine;

namespace Prototype
{
    public class Client : MonoBehaviour
    {
        void Start()
        {
            Prototype p1 = new ConcretePrototypeA("p1");
            Prototype p2 = new ConcretePrototypeB("p2");

            Prototype c1 = p1.Clone();
            c1.Log();
            Prototype c2 = p2.Clone();
            c2.Log();
        }

    }

}

