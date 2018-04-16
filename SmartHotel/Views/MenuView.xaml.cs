using System;
using System.Collections.Generic;
using SmartHotel.Models;
using Xamarin.Forms;

namespace SmartHotel.Views
{
    public partial class MenuView : ContentPage
    {
        public MenuView()
        {
            InitializeComponent();

            BindingContext = new MenuViewModel();
        }

        private void OnBookingMenuTapped(object sender, EventArgs args)
        {
            if (Application.Current.MainPage is MainView mainView)
            {

                if (mainView.Detail is NavigationPage naviagationPage)
                {
                    //
                    naviagationPage.PushAsync(new BookingView());

                    mainView.IsPresented = false;
                }
            }
        }

        private void OnMyRoomMenuTapped(object sender, EventArgs args)
        {
            if (Application.Current.MainPage is MainView mainView)
            {

                if (mainView.Detail is NavigationPage naviagationPage)
                {
                    //
                    naviagationPage.PushAsync(new MyRoomView());

                    mainView.IsPresented = false;
                }
            }
        }

        private void OnSuggesstionsMenuTapped(object sender, EventArgs args)
        {
            if (Application.Current.MainPage is MainView mainView)
            {

                if (mainView.Detail is NavigationPage naviagationPage)
                {
                    //
                    naviagationPage.PushAsync(new SuggesstionsView());

                    mainView.IsPresented = false;
                }
            }
        }

        private void OnConciergeMenuTapped(object sender, EventArgs args)
        {
            if (Application.Current.MainPage is MainView mainView)
            {

                if (mainView.Detail is NavigationPage naviagationPage)
                {
                    //
                    naviagationPage.PushAsync(new ConciergeView());

                    mainView.IsPresented = false;
                }
            }
        }

        private void OnLogOutMenuTapped(object sender, EventArgs args)
        {
            Application.Current.MainPage = new LoginView();
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (MyListView.SelectedItem == null)
                return;
            //TODO: Navigate

            MyListView.SelectedItem = null;
        }
    }
}
