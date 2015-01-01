using Logger;

namespace DesignPatterns.BehavioralPatterns.Observer.Structural
{
    /// <summary>
    ///     The 'ConcreteObserver' class
    /// </summary>
    internal class ConcreteObserver : Observer
    {
        private string _observerState;
        private readonly string _name;
   
        // Constructor
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            Subject = subject;
            _name = name;
        }

        // Gets or sets subject
        public ConcreteSubject Subject { get; set; }

        public override void Update()
        {
            _observerState = Subject.SubjectState;
            Log.WriteLine("Observer {0}'s new state is {1}", _name, _observerState);
        }
    }
}