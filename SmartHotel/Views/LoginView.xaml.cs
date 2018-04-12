using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SmartHotel.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            var userName = txtUserName.Text;
            var passWord = txtPassword.Text;

            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                DisplayAlert("Alert", "You are not enterd username or password", "OK");                
            }
            else
            {
                DisplayAlert("Alert", "You are log in", "OK");  
            }
        }
    }
}
