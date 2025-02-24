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
    internal class MainPageViewModel : ViewModelBase
    {
        #region fields
        private readonly INavigationService _navigationService;
        #endregion

        #region properties

        #endregion
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            _navigationService.NavigateTo(RegionNames.MainRegion, ViewNames.LoginView);
        }

        #region Commands

        #endregion
    }
}
