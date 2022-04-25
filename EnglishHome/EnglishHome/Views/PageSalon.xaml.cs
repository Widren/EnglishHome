using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace EnglishHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSalon : ContentPage
    {
        public PageSalon()
        {
            InitializeComponent();
            var list = new List<Models.Urunler>
              {
               new Models.Urunler { urun = "Vera Şönil Halı Gri", fiyat = 999.99, image = "hali.jpg" ,renk="Gri", rating=0.0 },
               new Models.Urunler { urun = "Fluffy Peluş Kırlent Kılıfı 45x45 cm Mürdüm", fiyat = 119.99, image = "kirlent.jpg", renk="Mürdüm",rating=0.0 },
               new Models.Urunler { urun = "Mace Polyester Masa Örtüsü 150x200 Cm Antrasit", fiyat = 149.99, image = "masaOrtusu.jpg", renk="Mavi" ,rating=0.0 },
               new Models.Urunler { urun = "Marcel Sehpa 30x30x30 Cm Krem", fiyat = 249.99, image = "sehpa.jpg", renk="Krem", rating=0.0 },

            };
            lstView.ItemsSource = list;

        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//PageMain");
        }
    }
}