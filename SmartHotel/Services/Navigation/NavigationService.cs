using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartHotel.ViewModels.Base;
using SmartHotel.Views;
using Xamarin.Forms;

namespace SmartHotel.Services.Navigation
{
    public partial class NavigationService: INavigationService
    {
        private readonly Dictionary<Type, Type> _mapping;

        public NavigationService()
        {
            _mapping = new Dictionary<Type, Type>();
            this.Mappings();
        }

        public Task NavigateBackAsync()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase
        {
            return NavigateToAsync(typeof(TViewModel), null);
        }

        public Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase
        {
            return NavigateToAsync(typeof(TViewModel), parameter);
        }

        public Task NavigateToAsync(Type viewModelType)
        {
            return NavigateToAsync(viewModelType, null);
        }

        public async Task NavigateToAsync(Type viewModelType, object parameter)
        {
            var pageType = _mapping[viewModelType];
            var page = (Page)Activator.CreateInstance(pageType);

            var viewModel = page.BindingContext = ServiceLocator.Instance.Resolve(viewModelType);

            if (page is LoginView)
            {
                Application.Current.MainPage = new NavigationPage(page);
            }
            else if(page is MainView)
            {
                Application.Current.MainPage = page;
            }
            await ((ViewModelBase)viewModel).InitializeAsync(parameter);

            //return Task.FromResult(0);

            //throw new NotImplementedException();
        }
    }
}
