using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;


namespace EnglishHome
{
    public partial class App : Application
    {

       
        public App()
        {
            InitializeComponent();

             MainPage = new PageShell();
            //MainPage = new Views.SettingsPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
