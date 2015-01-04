using System;
using System.Collections.Generic;
using Logger;

namespace DesignPatterns.BehavioralPatterns.Strategy.RealWorld
{
    /// <summary>
    ///     The 'Context' class
    /// </summary>
    internal class StrategySortedList
    {
        private SortStrategy _sortstrategy;
        private readonly List<string> _list = new List<string>();

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            _sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);

            // Iterate over list and display results
            foreach (var name in _list)
            {
                Log.WriteLine(" " + name);
            }
            Log.WriteLine("");
         
        }
    }
}