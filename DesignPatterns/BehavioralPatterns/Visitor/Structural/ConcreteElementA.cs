namespace DesignPatterns.BehavioralPatterns.Visitor.Structural
{
    /// <summary>
    ///     A 'ConcreteElement' class
    /// </summary>
    internal class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {
        }
    }
}