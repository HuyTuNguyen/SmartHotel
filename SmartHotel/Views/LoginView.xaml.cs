using System;
using System.Collections.Generic;
using SmartHotel.ViewModels;
using Xamarin.Forms;

namespace SmartHotel.Views
{
    public partial class LoginView : ContentPage
    {
        private LoginViewModel LoginViewModel { get; }

        public LoginView()
        {
            //
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        //void Handle_Clicked(object sender, System.EventArgs e)
        //{

        //    var userName = txtUserName.Text;
        //    var passWord = txtPassword.Text;

        //    if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
        //    {
        //        DisplayAlert("Alert", "You are not enter username or password", "OK");                
        //    }
        //    else
        //    {
        //        //Navigation.PushAsync(new MainView()); 
        //        App.Current.MainPage = new MainView();
        //    }
        //}
    }
}
