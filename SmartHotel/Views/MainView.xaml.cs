using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SmartHotel.Views
{
    public partial class MainView: MasterDetailPage
    {
        public MainView()
        {
            InitializeComponent();
        }

		/*
        protected override void OnAppearing()
		{
            base.OnAppearing();

            if(Navigation.NavigationStack[0] is LoginView)
                Navigation.RemovePage(Navigation.NavigationStack[0]);
		}
		*/
	}
}
