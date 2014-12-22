using Logger;

namespace DesignPatterns.StructuralPatterns.Facade.RealWorld
{
    /// <summary>
    /// The 'Subsystem ClassC' class
    /// </summary>
    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Log.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}