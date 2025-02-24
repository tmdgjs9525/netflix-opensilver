using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using netflix_opensilver.Core;
using netflix_opensilver.ViewModels;
using netflix_opensilver.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace netflix_opensilver
{
    public sealed partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();

            IServiceProvider provider = serviceInitialize();

            var mainView = provider.GetRequiredService<MainPage>();
            mainView.DataContext = provider.GetRequiredService<MainPageViewModel>();

            Window.Current.Content = mainView;
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
            Container container = new Container(services);

            container.AddSingletonNavigation<LoginView, LoginViewModel>();

            services.AddSingleton<MainPage>();
            services.AddSingleton<MainPageViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
