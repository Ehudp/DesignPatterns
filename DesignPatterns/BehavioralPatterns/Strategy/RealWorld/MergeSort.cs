using System.Collections.Generic;
using Logger;

namespace DesignPatterns.BehavioralPatterns.Strategy.RealWorld
{
    /// <summary>
    ///     A 'ConcreteStrategy' class
    /// </summary>
    internal class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Log.WriteLine("MergeSorted list ");
        }
    }
}