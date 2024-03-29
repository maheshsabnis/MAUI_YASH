﻿using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace MAUI_AppActions
{
    [IntentFilter(new[] { Platform.Intent.ActionAppAction}, Categories = new[] { Android.Content.Intent.CategoryDefault })]
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        /// <summary>
        /// Support the Lifecycle of the application so that if the Back Button is Pressed
        /// the Appliction Acceess is resumed
        /// </summary>
        protected override void OnResume()
        {
            base.OnResume();
            Platform.OnResume(this);
        }
        /// <summary>
        /// Loading the Shortcut on Tap and accordingly
        /// providing the Application Access
        /// </summary>
        /// <param name="intent"></param>
        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);
            Platform.OnNewIntent(intent);
        }
    }
}