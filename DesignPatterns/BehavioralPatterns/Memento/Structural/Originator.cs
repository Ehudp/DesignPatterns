using Logger;

namespace DesignPatterns.BehavioralPatterns.Memento.Structural
{
    internal class Originator
    {
        private string _state;
        // Property
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Log.WriteLine("State = " + _state);
            }
        }

        // Creates memento 
        public Memento CreateMemento()
        {
            return (new Memento(_state));
        }

        // Restores original state
        public void SetMemento(Memento memento)
        {
            Log.WriteLine("Restoring state...");
            State = memento.State;
        }
    }
}