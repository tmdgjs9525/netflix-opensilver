using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using netflix_opensilver.Core;
using netflix_opensilver.ViewModels;
using netflix_opensilver.Views;
using netflix_opensilver.Views.Main;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Interop;

namespace netflix_opensilver
{
    public sealed partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();

            Startup += App_Startup;
            IServiceProvider provider = serviceInitialize();

            var mainView = provider.GetRequiredService<MainPage>();
            mainView.DataContext = provider.GetRequiredService<MainPageViewModel>();

            Window.Current.Content = mainView;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            Application.Current.Host.NavigationStateChanged += Host_NavigationStateChanged;
            //Application.Current.Host.NavigationState = "/LoginView";
            Application.Current.Host.NavigationState = "/LoginView";
            Host_NavigationStateChanged(this, new System.Windows.Interop.NavigationStateChangedEventArgs("", "/LoginView"));

        }

        private void Host_NavigationStateChanged(object sender, System.Windows.Interop.NavigationStateChangedEventArgs e)
        {
            Console.WriteLine("ev");

            HandleNavigation(e.NewNavigationState);
        }

        private void HandleNavigation(string newState)
        {
            Console.WriteLine("1");
            // URL에서 페이지 이름 추출
            string pageName = newState.Trim('/');

            UserControl newPage = pageName switch
            {
                "LoginView" => new LoginView(),
                "MainView" => new MainView(),
                _ => new UserControl() // 없는 페이지 처리
            };
            var rootVisual = Application.Current.RootVisual as Page; Console.WriteLine("2");

            // 루트 그리드에 페이지 추가
            if (rootVisual.Content is TransitioningContentControl contentControl)
            {
                contentControl.Content = newPage;
                Console.WriteLine("3");
            }
        }

        private IServiceProvider serviceInitialize()
        {
            ServiceCollection services = new ServiceCollection();

            IServiceProvider provider = Configure.ConfigureService(services);

            Ioc.Default.ConfigureServices(provider);

            return provider;
        }
    }


    internal static class Configure
    {
        public static IServiceProvider ConfigureService(this IServiceCollection services)
        {
            services.AddSingleton<MainPage>();
            services.AddSingleton<MainPageViewModel>();

            Container container = new Container(services);

            container.AddSingletonNavigation<LoginView, LoginViewModel>();
            container.AddSingletonNavigation<MainView, MainViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
