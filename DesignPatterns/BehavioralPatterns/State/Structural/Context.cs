using Logger;

namespace DesignPatterns.BehavioralPatterns.State.Structural
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class StateContext
    {
        private State _state;

        // Constructor
        public StateContext(State state)
        {
            this.State = state;
        }

        // Gets or sets the state
        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Log.WriteLine("State: " +_state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}