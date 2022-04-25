using EnglishHome.Helpers;
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
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }
        void ButtonCart_Clicked(object sender, EventArgs e)
        {
            var cct = new CreateCartTable();
            if (cct.CreateTable())
            { DisplayAlert("success", "Cart Table Created", "OK"); }
            else
            { DisplayAlert("Error", "Error while creating table", "ok"); }
        }
    }
}