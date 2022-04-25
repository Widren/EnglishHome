using EnglishHome.Models;
using EnglishHome.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EnglishHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TumUrunler : ContentPage
    {
        
        public ObservableCollection<Urunler> SepeteEklenen { get; set; }
        public TumUrunler()
        {
            InitializeComponent();
            BindingContext = new ProductViewModel();
           
        }
     

         private void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _containter = BindingContext as ProductViewModel;
            MyListView.BeginRefresh();
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                MyListView.ItemsSource = _containter.Products;
            else
                MyListView.ItemsSource = _containter.Products.Where(i => i.renk.Contains(e.NewTextValue));

            MyListView.EndRefresh();

        }

    }
}