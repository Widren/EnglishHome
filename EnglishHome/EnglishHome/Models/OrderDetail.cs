using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishHome.Models
{
    class OrderDetail
    {
        public string OrderDetailID { get; set; }
        public string OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set;}
         public double Price { get; set; }
    }
}
