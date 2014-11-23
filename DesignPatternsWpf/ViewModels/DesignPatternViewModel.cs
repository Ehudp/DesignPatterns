using Infrastructures.ViewModels;

namespace DesignPatternsWpf.ViewModels
{
    public class DesignPatternViewModel : ViewModelBase
    {
        public string Name
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value, () => Name); }
        }
    }
}