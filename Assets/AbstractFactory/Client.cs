using UnityEngine;

namespace AbstractFactory
{
    public class Client : MonoBehaviour
    {
        private AbstractProductA productA;
        private AbstractProductB productB;

        private void Start()
        {
            AbstractFactory1 factory1 = new AbstractFactory1();
            CreateProduct(factory1);
            AbstractFactory2 factory2 = new AbstractFactory2();
            CreateProduct(factory2);
        }

        public void CreateProduct(AbstractFactory factory)
        {
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }
    }
}
