﻿using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    //.DeviceSerial("afebe167")                    
                    .ApkFile("App1.Android.apk")
                    .StartApp();
            }

            return ConfigureApp
                .Android
                //.DeviceSerial("afebe167")
                .ApkFile("App1.Android.apk")
                .StartApp();
        }
    }
}

