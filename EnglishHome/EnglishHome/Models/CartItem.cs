using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EnglishHome.Models
{
    [Table("CartItem")]
     public class CartItem
    {
        [PrimaryKey, AutoIncrement]
        public int CartItemID { get; set; }
        public int ProductID { get; set; }
       
        public string ProductName { get; set; }
        public double Price { get; set; }
        

    }
}
