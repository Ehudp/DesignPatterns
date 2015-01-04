using Logger;

namespace DesignPatterns.BehavioralPatterns.Visitor.RealWorld
{
    /// <summary>
    ///     A 'ConcreteVisitor' class
    /// </summary>
    internal class VacationVisitor : IVisitor
    {
        public void Visit(VisitorElement element)
        {
            var employee = element as Employee;

            // Provide 3 extra vacation days
            Log.WriteLine("{0} {1}'s new vacation days: {2}",
                employee.GetType().Name, employee.Name,
                employee.VacationDays);
        }
    }
}