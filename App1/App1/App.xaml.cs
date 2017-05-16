using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new App1.Sample();
        }

        protected override void OnStart()
        {
            MobileCenter.Start("210b4344-ddb0-41b5-b8c8-0ae9a7d5cb87", typeof(Analytics), typeof(Crashes));
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
