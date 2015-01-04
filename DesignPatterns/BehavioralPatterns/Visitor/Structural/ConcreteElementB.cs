namespace DesignPatterns.BehavioralPatterns.Visitor.Structural
{
    /// <summary>
    ///     A 'ConcreteElement' class
    /// </summary>
    internal class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        {
        }
    }
}