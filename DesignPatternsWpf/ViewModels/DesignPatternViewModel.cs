using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsWpf.ViewModels
{
    public class DesignPatternViewModel:ViewModelBase
    {
       
        public string Name
        {
            get { return GetProperty<string>(); ; }
            set { SetProperty(value, () => Name); }
        }
    }
}
