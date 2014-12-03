using System.Collections.Generic;
using Logger;

namespace DesignPatterns.CreationalPatterns.Builder.RealWorld
{
    internal class Vehicle
    {
        private readonly Dictionary<string, string> _parts =
            new Dictionary<string, string>();

        private readonly string _vehicleType;

        // Constructor
        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        // Indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Log.WriteLine("\n---------------------------");
            Log.WriteLine("Vehicle Type: {0}", _vehicleType);
            Log.WriteLine(" Frame : {0}", _parts["frame"]);
            Log.WriteLine(" Engine : {0}", _parts["engine"]);
            Log.WriteLine(" #Wheels: {0}", _parts["wheels"]);
            Log.WriteLine(" #Doors : {0}", _parts["doors"]);
        }
    }
}