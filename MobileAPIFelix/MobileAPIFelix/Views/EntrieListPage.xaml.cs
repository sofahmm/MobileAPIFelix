using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileAPIFelix.Model;
using MobileAPIFelix.Services;
using System.Collections.ObjectModel;

namespace MobileAPIFelix.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntrieListPage : ContentPage
    {
        ObservableCollection <EntrieModel> entrieModels = new ObservableCollection<EntrieModel>();
        public EntrieListPage()
        {
            InitializeComponent();
            
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
            entrieModels= await App.RequestManager.GetEntrieModels();
            LVDeds.ItemsSource = entrieModels;
        }

        private void SearchEntry_TextChanged(object sender, TextChangedEventArgs e)
        { 
            LVDeds.ItemsSource = entrieModels.Where(c => c.API.ToString().Contains(SearchEntry.Text) || c.Description.ToString().Contains(SearchEntry.Text)).ToList();
        }

        private void LVDeds_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new EntriePage()
            {
                BindingContext = e.SelectedItem as EntrieModel
            });
        }
    }
}