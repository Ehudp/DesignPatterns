﻿using DesignPatternsWpf.Model;
using DesignPatternsWpf.Services;
using Infrastructures.Common;
using Infrastructures.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DesignPatternsWpf.ViewModels
{
    public class DesignPatternViewModel : ViewModelBase
    {

        #region Ctor
        public DesignPatternViewModel()
        {
            FillPattrensColleection();
            SelectedItemChangedCommand = new RelayCommand<object>(OnSelectedItemChangedCommand);
        }

        private void OnSelectedItemChangedCommand(object obj)
        {
         
        }
        #endregion
        #region DataMembers

        private ObservableCollection<PatternDetails> _patterns;

        private PatternDetails _selectedPattern;

        #endregion

        #region Properties

        public ICommand SelectedItemChangedCommand { get; set; }

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

      

        public PatternDetails SelectedPattern
        {
            get { return _selectedPattern; }
            set { _selectedPattern = value; }
        }

        #endregion

        #region Methods

        private void FillPattrensColleection() 
        {
            List<PatternDetails> patterns = new List<PatternDetails>();

            patterns.Add(PatternServices.GetCreationalPatternsTree());
            Patterns = new ObservableCollection<PatternDetails>(patterns);
        }

        #endregion
    }
}