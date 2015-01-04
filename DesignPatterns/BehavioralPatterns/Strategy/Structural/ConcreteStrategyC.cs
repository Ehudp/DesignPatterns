using Logger;

namespace DesignPatterns.BehavioralPatterns.Strategy.Structural
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Log.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }
}