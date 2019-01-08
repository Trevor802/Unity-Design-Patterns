namespace Builder
{
    public class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Builder 2: Part A");
        }

        public override void BuildPartB()
        {
            product.Add("Builder 2: Part B");
        }

        public override Product GetProduct()
        {
            return product;
        }
    }
}

