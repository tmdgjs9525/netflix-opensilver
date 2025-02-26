using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace netflix_opensilver.Themes.Units
{
    internal class VideoPreview : Control
    {
        static VideoPreview()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VideoPreview), new FrameworkPropertyMetadata(typeof(VideoPreview)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

    }
}
