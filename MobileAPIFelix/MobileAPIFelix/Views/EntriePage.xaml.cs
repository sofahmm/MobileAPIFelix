using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileAPIFelix.Model;
using Xamarin.Essentials;

namespace MobileAPIFelix.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntriePage : ContentPage
    {
        public EntriePage()
        {
            InitializeComponent();
            
        }
        protected override void OnAppearing()
        {
                
            base.OnAppearing();
            if (HttpsEntry.Text == "True")
                HttpsEntry.Text = "Поддерживается";
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var url = (sender as Label).Text;
            Launcher.OpenAsync(new Uri(url));
        }
    }
}