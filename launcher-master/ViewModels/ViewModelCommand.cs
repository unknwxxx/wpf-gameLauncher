﻿using System;
using System.Windows.Input;

namespace launcher_master.ViewModels
{
    public class ViewModelCommand : ICommand
    {

        private readonly Action<object> _executeAction;
        private readonly Predicate<object> _canExecuteAction;
        private ICommand recoverPasswordCommand;

        public ViewModelCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = null;
        }

        public ViewModelCommand(Action<object> executeAction, Predicate<object> canExecuteAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }

        public ViewModelCommand(ICommand recoverPasswordCommand)
        {
            this.recoverPasswordCommand = recoverPasswordCommand;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecuteAction == null ? true : _canExecuteAction(parameter);
        }

        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }
    }
}
