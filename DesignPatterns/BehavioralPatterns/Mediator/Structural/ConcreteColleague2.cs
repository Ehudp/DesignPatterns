using Logger;

namespace DesignPatterns.BehavioralPatterns.Mediator.Structural
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class ConcreteColleague2 : Colleague
    {
        // Constructor
        public ConcreteColleague2(Mediator mediator)
            : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Log.WriteLine("Colleague2 gets message: "+ message);
        }
    }
}