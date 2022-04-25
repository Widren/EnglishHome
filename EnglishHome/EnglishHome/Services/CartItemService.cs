using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using EnglishHome.Models;

namespace EnglishHome.Services
{
    public class CartItemService
    {
        public int GetUserCartCount()
        {
            var cn = DependencyService.Get<ISQlite>().GetConnection();
            var count = cn.Table<CartItem>().Count();
            cn.Close();
            return count;
        }

        public void RemoveItemsFromCart()
        {
            var cn = DependencyService.Get<ISQlite>().GetConnection();
            cn.DeleteAll<CartItem>();
            cn.Commit();
            cn.Close();
            
        }
    }
}
