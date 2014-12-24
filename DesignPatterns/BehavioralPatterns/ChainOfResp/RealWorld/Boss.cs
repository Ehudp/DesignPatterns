using Logger;

namespace DesignPatterns.BehavioralPatterns.ChainOfResp.RealWorld
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    class Boss : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Log.WriteLine("{0} approved request# {1}",GetType().Name, purchase.Number);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }
}