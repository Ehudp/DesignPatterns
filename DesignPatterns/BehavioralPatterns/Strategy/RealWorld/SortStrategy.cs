using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.Strategy.RealWorld
{
    internal abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}