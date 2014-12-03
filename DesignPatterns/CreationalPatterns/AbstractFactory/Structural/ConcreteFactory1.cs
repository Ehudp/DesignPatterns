namespace DesignPatterns.CreationalPatterns.AbstractFactory.Structural
{
    class ConcreteFactory1:AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
