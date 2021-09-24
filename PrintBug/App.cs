using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.MobileBlazorBindings;
using Xamarin.Forms;

namespace PrintBug
{
    public class App : Application
    {
        public App()
        {
            var hostBuilder = MobileBlazorBindingsHost.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    // Adds web-specific services such as NavigationManager
                    services.AddBlazorHybrid();
                })
                .UseWebRoot("wwwroot")
                .UseStaticFiles()
            ;

            var host = hostBuilder.Build();

            MainPage = new ContentPage();
            NavigationPage.SetHasNavigationBar(MainPage, false);
            
            host.AddComponent<Main>(parent: MainPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
