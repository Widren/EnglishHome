using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SQLite;


namespace EnglishHome.Models
{
 
    public class Urunler 
    {
        [PrimaryKey, AutoIncrement]
        public int UrunID
        {
            get;
            set;
        }
        [PrimaryKey]
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public string urun
        {
            get;
            set;
        }
        public double fiyat
        {
            get;
            set;
        }
        public string image
        {
            get;
            set;
        }
        public string renk
        {
            get;
            set;
        }
        public double rating
        {
            get; set;
        }


    }
}
