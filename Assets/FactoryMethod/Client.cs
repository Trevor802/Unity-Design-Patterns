using UnityEngine;

namespace FactoryMethod
{
    public class Client : MonoBehaviour
    {
        private void Start()
        {
            Creator creatorA = new ConcreteCreatorA();
            Creator creatorB = new ConcreteCreatorB();
            creatorA.CreateProduct();
            creatorB.CreateProduct();
        }
    }
}
