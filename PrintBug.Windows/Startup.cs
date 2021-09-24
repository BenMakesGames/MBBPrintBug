using Microsoft.MobileBlazorBindings.WebView.Windows;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace PrintBug.Windows
{
    public class Startup : FormsApplicationPage
    {
        [STAThread]
        public static void Main()
        {
            var app = new System.Windows.Application();
            app.Run(new Startup());
        }

        public Startup()
        {
            Forms.Init();

            Title = "Print Bug";
            
            BlazorHybridWindows.Init();
            LoadApplication(new App());
        }
    }
}
