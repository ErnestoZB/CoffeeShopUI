﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AllProductsView());
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
