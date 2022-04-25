using EnglishHome.Services;
using EnglishHome.ViewModels;
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
    public partial class PageSepet : ContentPage
    {
        public PageSepet()
        {
            InitializeComponent();
           
        }
        protected override  void OnAppearing()
        {
            base.OnAppearing();
            CartViewModel scv = new CartViewModel();
            MyListView.ItemsSource = scv.CartItems;
        }
        private void SepetSil(object sender, EventArgs e)
        {
            CartItemService cis = new CartItemService();
            cis.RemoveItemsFromCart();
            CartViewModel scv = new CartViewModel();
            scv.CartItems.Clear();
            Navigation.PushAsync(new PageSepet());
            
        }
        private void HemenAl(object sender, EventArgs e)
        {
            //Ödeme ekranına gönder
            if (MyListView.SelectedItem == null)
            {
                Application.Current.MainPage.DisplayAlert("Sepet Boş", "Sepet Boş olduğu için işlem yapılamıyor", "Tamam");
            }
            else
                Navigation.PushModalAsync(new PageOdeme());
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageMain");

        }
    }
}