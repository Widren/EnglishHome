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
    public partial class PageYatakOdasi : ContentPage
    {
        public PageYatakOdasi()
        {
            InitializeComponent();
            var list = new List<Models.Urunler>
              {
                  new Models.Urunler { urun = "Softy Wellsoft Tv Battaniye 120x170 Cm Çikolata", fiyat = 149.99, image = "battaniye.jpg",renk="Çikolata", rating=0.0 },
                  new Models.Urunler { urun = "Liberty Bloom Pamuklu Çift Kişilik Nevresim Seti 200x220 Cm Tarçın", fiyat = 499.99, image = "nevresim.jpg" ,renk="Pembe",rating=0.0 },
                  new Models.Urunler { urun = "Silikonlu Yastık 50X70 Cm Ekru", fiyat = 99.99, image = "yastik.jpg" , renk="Beyaz" ,rating=0.0 },
                  new Models.Urunler { urun = "Siesta Mikrofiber Çift Kişilik Yorgan 195x215 Cm Beyaz", fiyat = 499.99, image = "yorgan.jpg", renk="Beyaz", rating=0.0  },
              };
            lstView.ItemsSource = list;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageMain");
        }
    }
}