using DesignPatternsWpf.Model;
using Infrastructures.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DesignPatternsWpf.ViewModels
{
    public class DesignPatternViewModel : ViewModelBase
    {
        #region DataMembers

        private ObservableCollection<PatternDetails> _patterns;

        #endregion

        #region Properties


        public string Name
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value, () => Name); }
        }


        public ObservableCollection<PatternDetails> Patterns
        {
            get { return _patterns; }
            set { _patterns = value; }
        }

        #endregion

        #region Methods

        private void FillPattrensColleection() 
        {
            List<PatternDetails> patterns = new List<PatternDetails>();


            Patterns = new ObservableCollection<PatternDetails>(patterns);
        }

        #endregion
    }
}