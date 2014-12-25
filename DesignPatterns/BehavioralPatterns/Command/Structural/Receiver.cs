using Logger;

namespace DesignPatterns.BehavioralPatterns.Command.Structural
{
    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    class Receiver
    {
        public void Action()
        {
            Log.WriteLine("Called Receiver.Action()");
        }
    }
}