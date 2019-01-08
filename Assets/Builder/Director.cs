using UnityEngine;

namespace Builder
{
    public class Director : MonoBehaviour
    {
        private void Start()
        {
            ConcreteBuilder1 builder1 = new ConcreteBuilder1();
            var product1 = Construct(builder1);
            product1.Show();

            ConcreteBuilder2 builder2 = new ConcreteBuilder2();
            var product2 = Construct(builder2);
            product2.Show();
        }

        public Product Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            return builder.GetProduct();
        }
    }
}

