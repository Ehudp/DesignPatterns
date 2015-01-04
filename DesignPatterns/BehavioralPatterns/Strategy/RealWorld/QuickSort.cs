using System.Collections.Generic;
using Logger;

namespace DesignPatterns.BehavioralPatterns.Strategy.RealWorld
{
    /// <summary>
    ///     A 'ConcreteStrategy' class
    /// </summary>
    internal class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); // Default is Quicksort
            Log.WriteLine("QuickSorted list ");
        }
    }
}