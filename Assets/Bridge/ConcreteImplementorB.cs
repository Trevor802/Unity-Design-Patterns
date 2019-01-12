using UnityEngine;

namespace Bridge
{
    public class ConcreteImplementorB : Implementor
    {
        public override void Operate()
        {
            Debug.Log("Concrete implementor B.");
        }
    }
}