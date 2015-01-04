using Logger;

namespace DesignPatterns.BehavioralPatterns.Strategy.Structural
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Log.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }
}