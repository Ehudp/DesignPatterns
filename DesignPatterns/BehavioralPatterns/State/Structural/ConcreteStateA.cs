namespace DesignPatterns.BehavioralPatterns.State.Structural
{
    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class ConcreteStateA : State
    {
        public override void Handle(StateContext context)
        {
            context.State = new ConcreteStateB();
        }
    }
}