using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_XAMARIN
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Master.Menu();
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
