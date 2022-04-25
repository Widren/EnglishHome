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
    public partial class PageBanyo : ContentPage
    {
        public PageBanyo()
        {
            InitializeComponent();
            var list = new List<Models.Urunler>
              {
                  new Models.Urunler { urun = "Quadro Pamuklu 4'lü Set Havlu Seti 30x40 Cm Beyaz - Bordo", fiyat = 119.99, image = "havlu.jpg", renk="Beyaz", rating=0.0},
                  new Models.Urunler { urun = "Casa Cam Banyo Sıvı Sabunluk 8x14 Cm Gold", fiyat = 29.99, image = "sabunluk.jpg", renk="Beyaz",rating=0.0 },
                  new Models.Urunler { urun = "Plain Pamuklu Bornoz L-xl Kiremit", fiyat = 349.99, image = "bornoz.jpg", renk="Kirmet" ,rating=0.0 },
                  new Models.Urunler { urun = "Evelyn 3'lü Banyo Seti Bej", fiyat = 299.99, image = "banyoSeti.jpg", renk="Bej", rating=0.0 },
              };
            lstView2.ItemsSource = list;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageMain");
        }

      

        private void Button_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}