using Logger;

namespace DesignPatterns.StructuralPatterns.Facade.RealWorld
{
    /// <summary>
    /// The 'Subsystem ClassB' class
    /// </summary>
    class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Log.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}