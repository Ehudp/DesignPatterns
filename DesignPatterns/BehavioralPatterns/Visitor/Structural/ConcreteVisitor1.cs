using Logger;

namespace DesignPatterns.BehavioralPatterns.Visitor.Structural
{
    /// <summary>
    ///     A 'ConcreteVisitor' class
    /// </summary>
    internal class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(
            ConcreteElementA concreteElementA)
        {
            Log.WriteLine("{0} visited by {1}",
                concreteElementA.GetType().Name, GetType().Name);
        }

        public override void VisitConcreteElementB(
            ConcreteElementB concreteElementB)
        {
            Log.WriteLine("{0} visited by {1}",
                concreteElementB.GetType().Name, GetType().Name);
        }
    }
}