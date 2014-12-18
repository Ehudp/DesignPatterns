namespace DesignPatterns.StructuralPatterns.Bridge.Structural
{
    internal class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}