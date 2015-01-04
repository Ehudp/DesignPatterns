namespace DesignPatterns.BehavioralPatterns.State.Structural
{
    internal abstract class State
    {
        public abstract void Handle(StateContext context);
    }
}