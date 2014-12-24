using Logger;

namespace DesignPatterns.BehavioralPatterns.ChainOfResp.Structural
{
    /// <summary>
    /// The 'ConcreteHandler1' class
    /// </summary>
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Log.WriteLine("{0} handled request {1}",
                    this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}