using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EnglishHome.Models
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryIcon { get; set; }
    }
}
