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
    public partial class PageOdeme : ContentPage
    {
        public PageOdeme()
        {
            InitializeComponent();
        }
        private async void Geri_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void BtnKyt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Odeme2());

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Adres());
        }
    }
}