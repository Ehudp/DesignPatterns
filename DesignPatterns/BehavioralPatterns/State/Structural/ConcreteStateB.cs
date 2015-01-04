namespace DesignPatterns.BehavioralPatterns.State.Structural
{
    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class ConcreteStateB : State
    {
        public override void Handle(StateContext context)
        {
            context.State = new ConcreteStateA();
        }
    }
}