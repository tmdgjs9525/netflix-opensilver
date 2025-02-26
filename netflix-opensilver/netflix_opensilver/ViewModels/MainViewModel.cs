using CommunityToolkit.Mvvm.ComponentModel;
using netflix_opensilver.Core;
using netflix_opensilver.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix_opensilver.ViewModels
{
    internal partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        public partial MediaInfo RecommendedItem { get; set; }

        [ObservableProperty]
        private MediaInfo test;

        [ObservableProperty]
        public partial ObservableCollection<RecommendationList> RecommendationList { get; set; }

        public MainViewModel()
        {
            RecommendedItem = new MediaInfo
            {
                PosterUrl = "https://occ-0-4960-993.1.nflxso.net/dnm/api/v6/6AYY37jfdO6hpXcMjf9Yu5cnmO0/AAAABTtqEr23wkU_fY69qASaHlwsopBiJnEWX0kZJs1SPUljgU7dXT_wj_RUm9gTSbwhXB4wNcNm7ZYteEIxssmgXWQjIZC8qOvlAXXT.webp?r=6e4",
                Description = "asdasa",
            };

        }
    }
}
