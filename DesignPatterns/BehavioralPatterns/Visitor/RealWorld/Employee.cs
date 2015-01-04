namespace DesignPatterns.BehavioralPatterns.Visitor.RealWorld
{
    /// <summary>
    ///     The 'ConcreteElement' class
    /// </summary>
    internal class Employee : VisitorElement
    {
        // Constructor
        public Employee(string name, double income,
            int vacationDays)
        {
            Name = name;
            Income = income;
            VacationDays = vacationDays;
        }

        // Gets or sets the name
        public string Name { get; set; }
        // Gets or sets income
        public double Income { get; set; }
        // Gets or sets number of vacation days
        public int VacationDays { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}