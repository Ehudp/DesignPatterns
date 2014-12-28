namespace DesignPatterns.BehavioralPatterns.Interpreter.RealWorld
{
    internal class RealContext
    {
        // Constructor
        public RealContext(string input)
        {
            Input = input;
        }

        // Gets or sets input
        public string Input { get; set; }
        // Gets or sets output
        public int Output { get; set; }
    }
}