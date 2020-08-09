﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_LayoutXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new App1_LayoutXF.MainPage()); 
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
