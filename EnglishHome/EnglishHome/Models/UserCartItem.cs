using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishHome.Models
{
    public class UserCartItem
    { 
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
       
        
        public double Price { get; set; }
        public double Cost { get; set; }
    }
}
