﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix_opensilver.Models
{
    public partial class RecommendationList : ObservableObject 
    {
        [ObservableProperty]
        public partial string RecommendationListName { get; set; }

        [ObservableProperty]
        public partial ObservableCollection<MediaInfo> RecommendList { get; set; }
    }
}
