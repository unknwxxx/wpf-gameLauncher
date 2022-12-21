using System;
using launcher_master.Repositories;
using System.Net;
using System.Security;
using System.Security.Principal;
using System.Threading;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows;

namespace launcher_master.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _login = null;
        private SecureString _password = null;
        private string _errorMessage = null;
        private bool _isViewVisible;

        private IUserRepository userRepository;

        public string Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }

        }

        public SecureString Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }

        }

        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }

            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }

        }

        public bool IsViewVisible
        {
            get => _isViewVisible;

            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }

        }

        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }


        public LoginViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                return;
            }
            else
            {
                userRepository = new UserRepository();
                LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
                RecoverPasswordCommand = new ViewModelCommand(i => ExecuteRecoverPassCommand("", ""));
            }
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            if (string.IsNullOrWhiteSpace(Login) || Login.Length < 4 || Password == null || Password.Length < 4)
                return false;
            else
                return true;
        }

        private void ExecuteLoginCommand(object obj)
        {
            var isValidUser = userRepository.AuthenticateUser(new NetworkCredential(Login, Password));

            if (isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(Login), null);
                IsViewVisible = false;
            }
            else
            {
                ErrorMessage = "* Invalid Login or Password";
            }

        }

        private void ExecuteRecoverPassCommand(string username, string email)
        {
            throw new NotImplementedException();
        }
    }
}
