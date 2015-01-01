using System.Collections.Generic;
using Logger;

namespace DesignPatterns.BehavioralPatterns.Observer.RealWorld
{
    internal abstract class Stock
    {
        private double _price;
        private readonly List<IInvestor> _investors = new List<IInvestor>();
        // Constructor
        public Stock(string symbol, double price)
        {
            Symbol = symbol;
            _price = price;
        }

        // Gets or sets the price
        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        // Gets the symbol
        public string Symbol { get; private set; }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }

            Log.WriteLine("");
        }
    }
}