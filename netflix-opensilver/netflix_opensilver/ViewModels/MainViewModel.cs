using CommunityToolkit.Mvvm.ComponentModel;
using netflix_opensilver.Core;
using netflix_opensilver.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace netflix_opensilver.ViewModels
{
    internal partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        public partial VideoInfo RecommendedItem { get; set; }

        [ObservableProperty]
        public partial ObservableCollection<RecommendationList> RecommendationList { get; set; }

        [ObservableProperty]
        public partial RecommendationList Test { get; set; }


        public MainViewModel()
        {
            RecommendedItem = new VideoInfo
            {
                PosterUrl = "https://occ-0-4960-993.1.nflxso.net/dnm/api/v6/6AYY37jfdO6hpXcMjf9Yu5cnmO0/AAAABTtqEr23wkU_fY69qASaHlwsopBiJnEWX0kZJs1SPUljgU7dXT_wj_RUm9gTSbwhXB4wNcNm7ZYteEIxssmgXWQjIZC8qOvlAXXT.webp?r=6e4",
                Description = "닥터 홈즈",
            };

            Test = new RecommendationList
            {
                RecommendationListName = "User를 위한 콘텐츠",
                RecommendList = new ObservableCollection<VideoInfo>
                {
                    new VideoInfo
                    {
                        PosterUrl = "https://occ-0-4960-993.1.nflxso.net/dnm/api/v6/Qs00mKCpRvrkl3HZAN5KwEL1kpE/AAAABRL5uUKHQnSZM6m9QBnI3eMCkB3GhhARVRFX4O_vSGv0ZC7DBYkMh3Yr_cXp75K0XYJ36Xmv9ai9OGhOz-NoDY4jQNrqB6N0ljHHdBJ2zxyaDF68qhF00e1OaSG8x4qAcPgORKUMH9NzkqCIjJr2-TJcuRNFHHCGi7A8Ropn-FMN7TfBJnsd_JRmwyX5MpntmaeWw1ZH3o_m4C7mhcZ-CppO6uUNgBIdj5ApY2Fyso5A8Vs6AsoDokmcfWugeL-fVRCdgyDtIGTQiCzZMw3aZiWDDGNAlp1RKL2dG6LkWd5ZCKoFa-hJDa7l1MdzO0Polptt4ekjA3NakbpeXWFWdw.webp?r=ef0",
                        LastWatchedEpisode = new Episode()
                        {
                            Season = 1,
                            EpisodeNumber = 1,
                            Title = "첫화",
                        }
                    },
                    new VideoInfo
                    {
                        PosterUrl = "https://occ-0-4960-993.1.nflxso.net/dnm/api/v6/Qs00mKCpRvrkl3HZAN5KwEL1kpE/AAAABRL5uUKHQnSZM6m9QBnI3eMCkB3GhhARVRFX4O_vSGv0ZC7DBYkMh3Yr_cXp75K0XYJ36Xmv9ai9OGhOz-NoDY4jQNrqB6N0ljHHdBJ2zxyaDF68qhF00e1OaSG8x4qAcPgORKUMH9NzkqCIjJr2-TJcuRNFHHCGi7A8Ropn-FMN7TfBJnsd_JRmwyX5MpntmaeWw1ZH3o_m4C7mhcZ-CppO6uUNgBIdj5ApY2Fyso5A8Vs6AsoDokmcfWugeL-fVRCdgyDtIGTQiCzZMw3aZiWDDGNAlp1RKL2dG6LkWd5ZCKoFa-hJDa7l1MdzO0Polptt4ekjA3NakbpeXWFWdw.webp?r=ef0",
                        LastWatchedEpisode = new Episode()
                        {
                            Season = 1,
                            EpisodeNumber = 1,
                            Title = "첫화",
                        }
                    },
                    new VideoInfo
                    {
                        PosterUrl = "https://occ-0-4960-993.1.nflxso.net/dnm/api/v6/Qs00mKCpRvrkl3HZAN5KwEL1kpE/AAAABRL5uUKHQnSZM6m9QBnI3eMCkB3GhhARVRFX4O_vSGv0ZC7DBYkMh3Yr_cXp75K0XYJ36Xmv9ai9OGhOz-NoDY4jQNrqB6N0ljHHdBJ2zxyaDF68qhF00e1OaSG8x4qAcPgORKUMH9NzkqCIjJr2-TJcuRNFHHCGi7A8Ropn-FMN7TfBJnsd_JRmwyX5MpntmaeWw1ZH3o_m4C7mhcZ-CppO6uUNgBIdj5ApY2Fyso5A8Vs6AsoDokmcfWugeL-fVRCdgyDtIGTQiCzZMw3aZiWDDGNAlp1RKL2dG6LkWd5ZCKoFa-hJDa7l1MdzO0Polptt4ekjA3NakbpeXWFWdw.webp?r=ef0",
                        LastWatchedEpisode = new Episode()
                        {
                            Season = 1,
                            EpisodeNumber = 1,
                            Title = "첫화",
                        }
                    }
                }
            };

        }
    }
}
