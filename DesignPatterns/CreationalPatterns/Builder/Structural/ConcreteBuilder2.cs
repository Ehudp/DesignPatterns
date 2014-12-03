namespace DesignPatterns.CreationalPatterns.Builder.Structural
{
    class ConcreteBuilder2 : CreationalPatterns.Builder.Structural.Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartX");
        }

        public override void BuildPartB()
        {
            _product.Add("PartY");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
