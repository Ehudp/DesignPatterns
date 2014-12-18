using System.Collections.Generic;
using Logger;

namespace DesignPatterns.StructuralPatterns.Bridge.RealWorld
{
    internal class CustomersData : DataObject
    {
        private int _current;
        private readonly List<string> _customers = new List<string>();

        public CustomersData()
        {
            // Loaded from a database 
            _customers.Add("Jim Jones");
            _customers.Add("Samual Jackson");
            _customers.Add("Allen Good");
            _customers.Add("Ann Stills");
            _customers.Add("Lisa Giolani");
        }

        public override void NextRecord()
        {
            if (_current <= _customers.Count - 1)
            {
                _current++;
            }
        }

        public override void PriorRecord()
        {
            if (_current > 0)
            {
                _current--;
            }
        }

        public override void AddRecord(string customer)
        {
            _customers.Add(customer);
        }

        public override void DeleteRecord(string customer)
        {
            _customers.Remove(customer);
        }

        public override void ShowRecord()
        {
            Log.WriteLine(_customers[_current]);
        }

        public override void ShowAllRecords()
        {
            foreach (var customer in _customers)
            {
                Log.WriteLine(" " + customer);
            }
        }
    }
}