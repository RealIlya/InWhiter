using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using System;
// using Android.Graphics;
using Xamarin.Forms.Platform.Android;

namespace InWhiter.Android.Activities
{
    [Activity(
        Label = "InWhiter",
        Theme = "@style/MainTheme",
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                               ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            Window window = Window;
            // if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            // {
            //     
            // }
            // window.SetNavigationBarColor(Color.WhiteSmoke.ToAndroid());
            // window.SetStatusBarColor(Color.FromRgb(243, 122, 84).ToAndroid());
            // window.NavigationBarDividerColor = 3;
        }
    }
}