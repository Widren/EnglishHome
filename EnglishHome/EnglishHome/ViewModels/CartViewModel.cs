using EnglishHome.Models;
using EnglishHome.Services;
using EnglishHome.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EnglishHome.ViewModels
{
    public class CartViewModel :BaseViewModel
    {
        public ObservableCollection<UserCartItem> CartItems { get; set; }
        private double _TotalCost;

        public double TotalCost
        {
            set
            {
                _TotalCost = value;
                OnPropertyChanged();
            }
            get { return _TotalCost; }
          
        }

        public Command PlaceOrderCommand { get; set; }
        public CartViewModel()
        {
            CartItems = new ObservableCollection<UserCartItem>();
            LoadItems();
           
        }

        private void LoadItems()
        {
            var cn = DependencyService.Get<ISQlite>().GetConnection();
            var items = cn.Table<CartItem>().ToList();
            CartItems.Clear();
            foreach(var item in items)
                {
                CartItems.Add(new UserCartItem()
                {
                    CartItemId = item.CartItemID,
                    ProductId = item.ProductID,
                    ProductName = item.ProductName,
                    Price = item.Price,
                    
                    
                   

                });
                
                }
        }

        

        private void RemoveItemsFromCart()
        {
            var cis = new CartItemService();
            cis.RemoveItemsFromCart();
        }
    }
}
