using System.Collections.Generic;
using Logger;

namespace DesignPatterns.BehavioralPatterns.Strategy.RealWorld
{
    /// <summary>
    ///     A 'ConcreteStrategy' class
    /// </summary>
    internal class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Log.WriteLine("ShellSorted list ");
        }
    }
}