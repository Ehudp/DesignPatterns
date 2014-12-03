namespace DesignPatterns.CreationalPatterns.AbstractFactory.RealWorld
{
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            Logger.Log.WriteLine(GetType().Name +
              " eats " + h.GetType().Name);            
        }
    }
}
