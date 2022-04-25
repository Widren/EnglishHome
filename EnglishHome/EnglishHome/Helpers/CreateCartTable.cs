using EnglishHome.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EnglishHome.Helpers
{
    public class CreateCartTable
    {
        public bool CreateTable()
        {
            try
            {
                var cn = DependencyService.Get<ISQlite>().GetConnection();
                cn.CreateTable<CartItem>();
                cn.Close();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
