using Logger;

namespace DesignPatterns.BehavioralPatterns.Visitor.RealWorld
{
    /// <summary>
    ///     A 'ConcreteVisitor' class
    /// </summary>
    internal class IncomeVisitor : IVisitor
    {
        public void Visit(VisitorElement element)
        {
            var employee = element as Employee;

            // Provide 10% pay raise
            employee.Income *= 1.10;
            Log.WriteLine("{0} {1}'s new income: {2:C}",
                employee.GetType().Name, employee.Name,
                employee.Income);
        }
    }
}