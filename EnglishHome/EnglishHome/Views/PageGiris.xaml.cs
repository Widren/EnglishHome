using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EnglishHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageGiris : ContentPage
    {
        public PageGiris()
        {
            InitializeComponent();
        }

        async void OnClicked(object o, EventArgs args)
        {
            await Navigation.PushAsync(new PageKayıt());
        }

        

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageMain");
        }
    }
}