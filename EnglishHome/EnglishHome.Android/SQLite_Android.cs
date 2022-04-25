using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnglishHome.Models;
using SQLite;
using System.IO;
using Xamarin.Forms;

[assembly:Dependency(typeof(EnglishHome.Droid.SQLite_Android))]
namespace EnglishHome.Droid
{
    public class SQLite_Android : ISQlite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabse.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);
            var cn = new SQLiteConnection(path);
            return cn;
        }
    }
}