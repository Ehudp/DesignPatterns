using Logger;

namespace DesignPatterns.StructuralPatterns.Proxy.Structural
{
    /// <summary>
    /// The 'RealSubject' class
    /// </summary>
    class RealSubject : Subject
    {
        public override void Request()
        {
            Log.WriteLine("Called RealSubject.Request()");
        }
    }
}