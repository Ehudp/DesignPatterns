using System.Collections.Generic;
using Logger;

namespace DesignPatterns.CreationalPatterns.Builder.Structural
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
