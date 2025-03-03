using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace netflix_opensilver.Themes.Units
{
    internal class VideoPreview : Control
    {
        private readonly ScaleTransform _scaleTransform;
        private readonly Storyboard _expandStoryboard;
        private readonly Storyboard _shrinkStoryboard;

        private Panel _bottomPanel;
        public VideoPreview()
        {
            DefaultStyleKey = typeof(VideoPreview);

            _scaleTransform = new ScaleTransform();
            RenderTransform = _scaleTransform;
            RenderTransformOrigin = new Point(0.5, 0.5); // 중심을 기준으로 확대/축소

            MouseEnter += OnMouseEnter;
            MouseLeave += OnMouseLeave;

            // 애니메이션 설정 (스케일 변화)
            _expandStoryboard = CreateScaleAnimation(1, 1.5);
            _shrinkStoryboard = CreateScaleAnimation(1.5, 1);

            _shrinkStoryboard.Completed += (s, e) =>
            {
                _bottomPanel.Visibility = Visibility.Collapsed;
            };
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _bottomPanel = (Panel)GetTemplateChild("BottomMenu");
        }

        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            _shrinkStoryboard.Begin();
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            //Canvas.SetZIndex(this,-10);
            _bottomPanel.Visibility = Visibility.Visible;
            _expandStoryboard.Begin();
        }


        private Storyboard CreateScaleAnimation(double from, double to)
        {
            var storyboard = new Storyboard();

            // X축 스케일 애니메이션
            var scaleXAnimation = new DoubleAnimation()
            {
                From = from,
                To = to,
                Duration = TimeSpan.FromMilliseconds(400),
                EasingFunction = new SineEase { EasingMode = EasingMode.EaseOut }
            };
            Storyboard.SetTarget(scaleXAnimation, _scaleTransform);
            Storyboard.SetTargetProperty(scaleXAnimation, new PropertyPath(ScaleTransform.ScaleXProperty));

            // Y축 스케일 애니메이션
            var scaleYAnimation = new DoubleAnimation()
            {
                From = from,
                To = to,
                Duration = TimeSpan.FromMilliseconds(400),
                EasingFunction = new SineEase { EasingMode = EasingMode.EaseOut }
            };
            Storyboard.SetTarget(scaleYAnimation, _scaleTransform);
            Storyboard.SetTargetProperty(scaleYAnimation, new PropertyPath(ScaleTransform.ScaleYProperty));

            // 애니메이션 적용
            storyboard.Children.Add(scaleXAnimation);
            storyboard.Children.Add(scaleYAnimation);

            return storyboard;
        }
    }
}
