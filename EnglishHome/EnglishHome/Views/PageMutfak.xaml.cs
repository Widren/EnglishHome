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
    public partial class PageMutfak : ContentPage
    {
        public PageMutfak()
        {
            InitializeComponent();
            var list = new List<Models.Urunler>
              {
                  new Models.Urunler { urun = "Icy Alüminyum Döküm Tencere Seti 7 Parça Siyah", fiyat = 2449.99, image = "tencere.jpg",renk="Siyah", rating=0.0 },
                  new Models.Urunler { urun = "Cassidy Cam Kavanoz 1100 Ml Şeffaf", fiyat = 109.99, image = "kavanoz.jpg",renk="Kahverengi",rating=0.0  },
                  new Models.Urunler { urun = "Pamira Porselen 6 Kişilik Kahve Fincan Takımı 80 Ml Mavi", fiyat = 249.99, image = "fincan.jpg", renk="Mavi" ,rating=0.0  },
                  new Models.Urunler { urun = "Galia Butterfly Bone Porselen 12 Parça Yemek Takımı 25 - 20 - 15 Cm Pembe", fiyat = 1199.99, image = "tabak.jpg" , renk="Beyaz-Altın", rating=0.0 },
              };
            lstView.ItemsSource = list;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageMain");
        }
    }
}