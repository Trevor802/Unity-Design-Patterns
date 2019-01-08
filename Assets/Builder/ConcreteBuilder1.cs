namespace Builder
{
    public class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Builder 1: Part A");
        }

        public override void BuildPartB()
        {
            product.Add("Builder 1: Part B");
        }

        public override Product GetProduct()
        {
            return product;
        }
    }
}

