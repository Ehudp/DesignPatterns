namespace DesignPatterns.BehavioralPatterns.Mediator.Structural
{
    internal abstract class Mediator
    {
        public abstract void Send(string message,Colleague colleague);
    }
}