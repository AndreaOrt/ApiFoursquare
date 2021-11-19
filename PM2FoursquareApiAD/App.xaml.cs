﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2FoursquareApiAD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.FourSquarePage();
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