using CommunityToolkit.Mvvm.Input;
using netflix_opensilver.Core;
using netflix_opensilver.Core.Navigate;
using netflix_opensilver.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix_opensilver.ViewModels
{
    internal partial class LoginViewModel : ViewModelBase
    {
        #region fields
        private readonly INavigationService _navigationService;
        #endregion
        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

        }

        [RelayCommand]
        private void Login()
        {
            _navigationService.NavigateTo(RegionNames.MainRegion, ViewNames.MainView);
        }
    }
}
