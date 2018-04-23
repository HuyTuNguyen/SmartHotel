using System;
using System.Collections.Generic;
using SmartHotel.Mvvm.Commands;
using SmartHotel.ViewModels.Base;

namespace SmartHotel.ViewModels
{
    public class MenuViewModel: ViewModelBase
    {
        public List<MenuItem> Menus { get; set; }

        public class MenuItem
        {

            public string Icon { get; set; }

            public string Title { get; set; }

            public Type ViewModelType { get; set; }
        }

        public MenuViewModel()
        {
            Menus = new List<MenuItem>
            {
                new MenuItem { Icon = "ic_bed", Title = "Book a room", ViewModelType = typeof(BookingViewModel) },
                new MenuItem { Icon = "ic_key", Title = "My room", ViewModelType = typeof(MyRoomViewModel) },
                new MenuItem { Icon = "ic_beach", Title = "Suggestions" , ViewModelType = typeof(SuggesstionsViewModel) },
                new MenuItem { Icon = "ic_bot", Title = "Concierge", ViewModelType = typeof(ConciergeViewModel) },
                new MenuItem { Icon = "ic_logout", Title = "Log out" }
            };
            MenuSelectedCommand = new DelegateCommand<object>(SeletedItem);
        }

        private void SeletedItem(object p)
        {
            if(p is MenuItem menuItem)
            {
                if(menuItem.ViewModelType != null)
                {
                    NavigationService.NavigateToAsync(menuItem.ViewModelType);
                }
                else
                {
                    //logout
                }
            }
        }

        public DelegateCommand<object> MenuSelectedCommand { get; }
    }
}
