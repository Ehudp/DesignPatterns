namespace DesignPatterns.BehavioralPatterns.Strategy.Structural
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class StrategyContext
    {
        private Strategy _strategy;

        // Constructor
        public StrategyContext(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}