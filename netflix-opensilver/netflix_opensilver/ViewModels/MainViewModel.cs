using CommunityToolkit.Mvvm.ComponentModel;
using netflix_opensilver.Core;
using netflix_opensilver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix_opensilver.ViewModels
{
    internal partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        private partial MediaInfo RecommendedItem { get; set; }

        public MainViewModel()
        {
            RecommendedItem = new MediaInfo
            {
                PosterUrl = "https://occ-0-4960-993.1.nflxso.net/dnm/api/v6/6AYY37jfdO6hpXcMjf9Yu5cnmO0/AAAABfbig2zd031EliCvJbjxKH9daeu9IgJYQEVbbVcXjGpMS990_Y6QsqerZdCZQiTgqTBNDHq0BloY9G-R8Q-sjHrPHI4ObuAGXsRN.webp?r=ad0",
                Description = "가나다라마바사아카차자파타라 나라다라아라마 바아라다라아나라달아ㅏ",
            };
        }
    }
}
