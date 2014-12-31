using Logger;

namespace DesignPatterns.BehavioralPatterns.Mediator.RealWorld
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class NonBeatle : Participant
    {
        // Constructor
        public NonBeatle(string name): base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Log.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}