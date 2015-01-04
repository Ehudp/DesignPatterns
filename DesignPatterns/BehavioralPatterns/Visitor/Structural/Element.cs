namespace DesignPatterns.BehavioralPatterns.Visitor.Structural
{
    /// <summary>
    ///     The 'Element' abstract class
    /// </summary>
    internal abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}