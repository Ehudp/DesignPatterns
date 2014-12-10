using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace DesignPatterns.StructuralPatterns.Adapter.RealWorld
{
    class Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        // Constructor
        public Compound(string chemical)
        {
            this._chemical = chemical;
        }

        public virtual void Display()
        {
            Log.WriteLine("\nCompound: {0} ------ ", _chemical);
        }
    }
}
