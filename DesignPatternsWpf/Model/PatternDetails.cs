﻿using System.Security.Policy;
using Infrastructures.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsWpf.Model
{
    public class PatternDetails : ViewModelBase
    {

        public PatternDetails()
        {
            Patterns = new List<PatternDetails>();         
            OutPutAction = UpdateOutPut;
        }
        public string Name
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value, () => Name); }
        }

        public string Header
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value, () => Header); }
        }

        public Action Method
        {
            get { return GetProperty<Action>(); }
            set { SetProperty(value, () => Method); }
        }
      

        public List<Uri> UrlsList
        {
            get { return GetProperty<List<Uri>>(); }
            set { SetProperty(value, () => UrlsList); }
        }

        public string OutPut
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value, () => OutPut); }
        }

        public List<PatternDetails> Patterns
        {
            get { return GetProperty<List<PatternDetails>>(); }
            set { SetProperty(value, () => Patterns); }
        }

        public string Detailes
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value, () => Detailes); }
        }

        public string ImageUrl
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value, () => ImageUrl); }
        }

        public Action<string,bool> OutPutAction { get; set; }

        private void UpdateOutPut(string msg,bool lineDown)
        {

            OutPut += msg;
            if (lineDown)
            {
                OutPut += "\n";
            }
        }

        public void Run()
        {
            OutPut = string.Empty;
            if (Method != null)
            {
                Method();
            }
        }
    }
}
