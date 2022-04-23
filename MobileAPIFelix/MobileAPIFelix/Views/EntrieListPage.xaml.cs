using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileAPIFelix.Model;
using MobileAPIFelix.Services;

namespace MobileAPIFelix.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntrieListPage : ContentPage
    {
        public EntrieListPage()
        {
            InitializeComponent();
            
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
            LVDeds.ItemsSource = await App.RequestManager.GetEntrieModels();
        }
    }
}