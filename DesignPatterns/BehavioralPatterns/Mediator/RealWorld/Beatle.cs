using Logger;

namespace DesignPatterns.BehavioralPatterns.Mediator.RealWorld
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class Beatle : Participant
    {
        // Constructor
        public Beatle(string name): base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Log.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}