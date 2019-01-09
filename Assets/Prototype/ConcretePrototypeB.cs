using UnityEngine;

namespace Prototype
{
    public class ConcretePrototypeB : Prototype
    {
        public ConcretePrototypeB(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return MemberwiseClone() as ConcretePrototypeB;
        }

        public override void Log()
        {
            Debug.Log("Concrete Prototype B: " + Id);
        }
    }
}