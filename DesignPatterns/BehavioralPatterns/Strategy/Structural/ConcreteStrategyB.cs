using Logger;

namespace DesignPatterns.BehavioralPatterns.Strategy.Structural
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Log.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
}