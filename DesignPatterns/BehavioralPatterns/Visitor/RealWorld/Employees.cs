using System.Collections.Generic;
using Logger;

namespace DesignPatterns.BehavioralPatterns.Visitor.RealWorld
{
    /// <summary>
    ///     The 'ObjectStructure' class
    /// </summary>
    internal class Employees
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var e in _employees)
            {
                e.Accept(visitor);
            }
            Log.WriteLine("");
        }
    }
}