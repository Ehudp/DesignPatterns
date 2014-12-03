using Logger;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.RealWorld
{
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Log.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);          
        }
    }
}
