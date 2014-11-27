using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Infrastructures.Common
{
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _action;
        private readonly Func<T, bool> _canExecute;

        public RelayCommand(Action<T> action)
        {
            _action = action;
        }

        public RelayCommand(Action<T> action, Func<T, bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null) return true;

            return _canExecute((T)parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (_action == null) return;

            _action((T)parameter);
        }

        #endregion

        public void RefreshCanExecute()
        {
            if (CanExecuteChanged == null) return;

            CanExecuteChanged(this, new EventArgs());
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action _action;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action action)
        {
            _action = action;
        }

        public RelayCommand(Action action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null) return true;

            return _canExecute();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (_action == null) return;

            _action();
        }

        #endregion

        public void RefreshCanExecute()
        {
            if (CanExecuteChanged == null) return;

            CanExecuteChanged(this, new EventArgs());
        }
    }
}
