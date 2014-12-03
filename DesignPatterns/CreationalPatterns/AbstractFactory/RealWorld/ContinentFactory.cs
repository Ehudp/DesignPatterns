namespace DesignPatterns.CreationalPatterns.AbstractFactory.RealWorld
{
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
