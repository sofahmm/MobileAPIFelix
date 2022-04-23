using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileAPIFelix.Services;

namespace MobileAPIFelix
{
    public partial class App : Application
    {
        public static RequestManager RequestManager { get; private set; }
        public App()
        {
            InitializeComponent();
            RequestManager = new RequestManager(new RestService());
            MainPage = new NavigationPage(new Views.EntrieListPage());
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
