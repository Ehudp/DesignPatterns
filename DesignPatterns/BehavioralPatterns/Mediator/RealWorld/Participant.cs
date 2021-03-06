using Logger;

namespace DesignPatterns.BehavioralPatterns.Mediator.RealWorld
{
    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>
    class Participant
    {
        private Chatroom _chatroom;
        private readonly string _name;

        // Constructor
        public Participant(string name)
        {
            this._name = name;
        }

        // Gets participant name
        public string Name
        {
            get { return _name; }
        }

        // Gets chatroom
        public Chatroom Chatroom
        {
            set { _chatroom = value; }
            get { return _chatroom; }
        }

        // Sends message to given participant
        public void Send(string to, string message)
        {
            _chatroom.Send(_name, to, message);
        }

        // Receives message from given participant
        public virtual void Receive(string from, string message)
        {
            Log.WriteLine("{0} to {1}: '{2}'",from, Name, message);
        }
    }
}