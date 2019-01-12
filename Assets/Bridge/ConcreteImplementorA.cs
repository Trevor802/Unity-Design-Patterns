using UnityEngine;

namespace Bridge
{
    public class ConcreteImplementorA : Implementor
    {
        public override void Operate()
        {
            Debug.Log("Concrete implementor A.");
        }
    }
}