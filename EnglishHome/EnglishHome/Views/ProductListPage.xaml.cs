using EnglishHome.Models;
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
    public partial class ProductListPage : ContentPage
    {
        public int CategoryID, SubCategoryID;
        public ProductListPage(int categoryID, int subCategoryID)
        {
            InitializeComponent();
            CategoryID = categoryID;
            SubCategoryID = subCategoryID;
        }
       

        private async void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ProductDetailPage
                {
                    BindingContext = e.SelectedItem as Urunler
                });
            }
        }

        private async void MyListView_ItemSelected_1(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ProductDetailPage
                {
                    BindingContext = e.SelectedItem as Urunler
                });
            }
        }

        protected override  void OnAppearing()
        {
            base.OnAppearing();
           
            ProductViewModel plv = new ProductViewModel(CategoryID, SubCategoryID);
            MyListView.ItemsSource = plv.Products;
        }
    }
}