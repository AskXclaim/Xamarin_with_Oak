﻿using System;
using LetsBegin.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace LetsBegin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();

            MainPage = new NavigationPage(new Navigation())
            {
                BarBackgroundColor  = Color.DodgerBlue,
                BarTextColor = Color.Black
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}