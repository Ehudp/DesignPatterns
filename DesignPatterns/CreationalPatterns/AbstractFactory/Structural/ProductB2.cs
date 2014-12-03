using Logger;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Structural
{
    class ProductB2:AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Log.WriteLine(GetType().Name +
              " interacts with " + a.GetType().Name);          
        }
    }
}
