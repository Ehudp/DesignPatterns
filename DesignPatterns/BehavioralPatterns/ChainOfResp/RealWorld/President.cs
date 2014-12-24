using Logger;

namespace DesignPatterns.BehavioralPatterns.ChainOfResp.RealWorld
{
    /// <summary>
    ///     The 'ConcreteHandler' class
    /// </summary>
    internal class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Log.WriteLine("{0} approved request# {1}",GetType().Name, purchase.Number);
            }
            else
            {
                Log.WriteLine("Request# {0} requires an executive meeting!",purchase.Number);
            }
        }
    }
}