using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TikTokApp.Vistas;

namespace TikTokApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Reproductor();
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
