using System;
using System.Collections.Generic;
using System.Text;
using SmartHotel.ViewModels;
using SmartHotel.ViewModels.Base;
using SmartHotel.Views;
using Xamarin.Forms;

namespace SmartHotel.Services.Navigation
{
    public partial class NavigationService
    {
        private void Mappings()
        {
            Map<LoginViewModel, LoginView>();
            Map<MainViewModel, MainView>();

            //
            Map<HomeViewModel, HomeView>();
            Map<BookingViewModel, BookingView>();
            Map<ConciergeViewModel, ConciergeView>();
            Map<MyRoomViewModel, MyRoomView>();
            Map<SuggesstionsViewModel, SuggesstionsView>();
        }

        private void Map<TViewModel, TView>() 
            where TViewModel : ViewModelBase
            where TView : Page        
        {
            _mapping.Add(typeof(TViewModel), typeof(TView));
        }
    }
}