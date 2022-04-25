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
    public partial class PageCategory : ContentPage
    {
        public PageCategory()
        {
            InitializeComponent();
        }

        private void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Category catgo = new Category();
                catgo = e.SelectedItem as Category;
                if (catgo.CategoryTitle == "Yatak Odası")
                {
                    CategoryViewModel ctg = new CategoryViewModel();
                    ctg.SubCats(1);
                    MyListView.ItemsSource = ctg.Category;
                    OnPropertyChanged();
                }
                else if (catgo.CategoryTitle == "Mutfak")
                {
                    CategoryViewModel ctg = new CategoryViewModel();
                    ctg.SubCats(2);
                    MyListView.ItemsSource = ctg.Category;
                    OnPropertyChanged();
                }
                else if (catgo.CategoryTitle == "Banyo")
                {
                    CategoryViewModel ctg = new CategoryViewModel();
                    ctg.SubCats(3);
                    MyListView.ItemsSource = ctg.Category;
                    OnPropertyChanged();
                }
                else if (catgo.CategoryTitle == "Salon")
                {
                    CategoryViewModel ctg = new CategoryViewModel();
                    ctg.SubCats(4);
                    MyListView.ItemsSource = ctg.Category;
                    OnPropertyChanged();
                }
                //////////
                else if (catgo.CategoryTitle == "Battaniye")
                {
                    Navigation.PushAsync(new ProductListPage(1, 1));
                }
                else if (catgo.CategoryTitle == "Nevresim Seti")
                {
                    Navigation.PushAsync(new ProductListPage(1, 2));
                }
                else if (catgo.CategoryTitle == "Yastık")
                {
                    Navigation.PushAsync(new ProductListPage(1, 3));
                }
                else if (catgo.CategoryTitle == "Yorgan")
                {
                    Navigation.PushAsync(new ProductListPage(1, 4));
                }
                /////
                else if (catgo.CategoryTitle == "Tencere")
                {
                    Navigation.PushAsync(new ProductListPage(2, 5));
                }
                else if (catgo.CategoryTitle == "Kavanoz")
                {
                    Navigation.PushAsync(new ProductListPage(2, 6));
                }
                else if (catgo.CategoryTitle == "Fincan Seti")
                {
                    Navigation.PushAsync(new ProductListPage(2, 7));
                }
                else if (catgo.CategoryTitle == "Yemek Takımı")
                {
                    Navigation.PushAsync(new ProductListPage(2, 8));
                }
                /////
                else if (catgo.CategoryTitle == "Havlu")
                {
                    Navigation.PushAsync(new ProductListPage(3, 9));
                }
                else if (catgo.CategoryTitle == "Sabunluk")
                {
                    Navigation.PushAsync(new ProductListPage(3, 10));
                }
                else if (catgo.CategoryTitle == "Bornoz")
                {
                    Navigation.PushAsync(new ProductListPage(3, 11));
                }
                else if (catgo.CategoryTitle == "Banyo Seti")
                {
                    Navigation.PushAsync(new ProductListPage(3, 12));
                }
                ////
                else if (catgo.CategoryTitle == "Halı")
                {
                    Navigation.PushAsync(new ProductListPage(4, 13));
                }
                else if (catgo.CategoryTitle == "Kırlent")
                {
                    Navigation.PushAsync(new ProductListPage(4, 14));
                }
                else if (catgo.CategoryTitle == "Masa Örtüsü")
                {
                    Navigation.PushAsync(new ProductListPage(4, 15));
                }
                else if (catgo.CategoryTitle == "Sehpa")
                {
                    Navigation.PushAsync(new ProductListPage(4, 16));
                }
            }
        }
                protected override  void OnAppearing()
        {
            base.OnAppearing();
            CategoryViewModel ctg = new CategoryViewModel();
            MyListView.ItemsSource = ctg.Category;
        }
    }
    }
