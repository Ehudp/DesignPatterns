namespace DesignPatterns.BehavioralPatterns.Command.RealWorld
{
    internal abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}