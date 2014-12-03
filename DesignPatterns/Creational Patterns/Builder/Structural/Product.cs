using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Builder.Structural
{
    class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
           
            Log.WriteLine("\nProduct Parts -------");
            foreach (string part in _parts)
                Log.WriteLine(part);
        }
    }
}
