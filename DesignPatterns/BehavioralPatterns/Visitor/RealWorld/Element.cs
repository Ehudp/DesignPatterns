namespace DesignPatterns.BehavioralPatterns.Visitor.RealWorld
{
    /// <summary>
    ///     The 'Element' abstract class
    /// </summary>
    internal abstract class VisitorElement
    {
        public abstract void Accept(IVisitor visitor);
    }
}