using UnityEngine;

namespace Prototype
{
    public class ConcretePrototypeA : Prototype
    {
        public ConcretePrototypeA(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return MemberwiseClone() as ConcretePrototypeA;
        }

        public override void Log()
        {
            Debug.Log("Concrete Prototype A: " + Id);
        }
    }
}