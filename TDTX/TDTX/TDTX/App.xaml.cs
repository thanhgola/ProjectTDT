﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TDTX.Views;
using Xamarin.Forms;

namespace TDTX
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeSetting();
            Debug.WriteLine(nameof(AppProperties.Dictionary));
            //this.Resources = new ResourceDictionary();
            //this.Resources.MergedWith = typeof(Xamarin.Forms.Themes.LightThemeResources);
            MainPage = new MainPage();
            
        }
        //protected override void OnStart()
        //{
        //    // Handle when your app starts         
        //}

        //protected override void OnSleep()
        //{
        //    // Handle when your app sleeps
        //}

        //protected override void OnResume()
        //{
        //    // Handle when your app resumes
        //}
    }
}
