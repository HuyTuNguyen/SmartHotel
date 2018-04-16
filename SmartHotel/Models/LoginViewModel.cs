using System;
using System.ComponentModel;

namespace SmartHotel.Models
{
    public class LoginViewModel:INotifyPropertyChanged
    {
        public LoginViewModel()
        {
            
        }

        private string _username = String.Empty;
        private string _password = String.Empty;
        private string _passwordStrength = String.Empty;

        public string Username 
        {
            get => _username;
            set
            {
                if(_username != value)
                {
                    _username = value;
                    RaisePropertyChanged(nameof(Username));
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    RaisePropertyChanged(nameof(Password));

                    if (_password != null && _password.Length > 6)
                        PasswordStrength = "Good";
                    else
                        PasswordStrength = "Invalid"; 
                }
            }
        }


        public string PasswordStrength
        {
            get => _passwordStrength;
            set
            {
                if (_passwordStrength != value)
                {
                    _passwordStrength = value;
                    RaisePropertyChanged(nameof(PasswordStrength));
                }
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string PassWord { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
