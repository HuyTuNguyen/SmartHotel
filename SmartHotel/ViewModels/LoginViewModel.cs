using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SmartHotel.Mvvm.Commands;
using SmartHotel.Services;
using SmartHotel.Services.Navigation;
using SmartHotel.ViewModels.Base;

namespace SmartHotel.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public DelegateCommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand(Login, CamLogin).ObservesProperty(() => Username).ObservesProperty(() => Password);
        }

        private bool CamLogin()
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }

        private void Login()
        {
            NavigationService.NavigateToAsync<MainViewModel>();
        }
    }
}