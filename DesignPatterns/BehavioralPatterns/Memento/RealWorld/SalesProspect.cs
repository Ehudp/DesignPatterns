using Logger;

namespace DesignPatterns.BehavioralPatterns.Memento.RealWorld
{
    internal class SalesProspect
    {
        private double _budget;
        private string _name;
        private string _phone;
        // Gets or sets name
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                Log.WriteLine("Name:  " + _name);
            }
        }

        // Gets or sets phone
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                Log.WriteLine("Phone: " + _phone);
            }
        }

        // Gets or sets budget
        public double Budget
        {
            get { return _budget; }
            set
            {
                _budget = value;
                Log.WriteLine("Budget: " + _budget);
            }
        }

        // Stores memento
        public Memento SaveMemento()
        {
            Log.WriteLine("\nSaving state --\n");
            return new Memento(_name, _phone, _budget);
        }

        // Restores memento
        public void RestoreMemento(Memento memento)
        {
            Log.WriteLine("\nRestoring state --\n");
            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;
        }
    }
}