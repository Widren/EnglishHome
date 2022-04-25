using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EnglishHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Adres : ContentPage
    {
        public Adres()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PageOdeme());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PageOdeme());

        }
        private void Geri_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageOdeme");
        }
    }
}