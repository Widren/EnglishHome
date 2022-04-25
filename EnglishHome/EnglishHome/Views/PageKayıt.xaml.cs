using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace EnglishHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageKayıt : ContentPage
    {
        public PageKayıt()
        {
            InitializeComponent();
            
        }

       
        private void Geri_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}