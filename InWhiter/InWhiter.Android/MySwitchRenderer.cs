using System;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using Google.Android.Material.Snackbar;
using InWhiter.Android;
using InWhiter.Utilities;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Xamarin.Forms.Color;
using Switch = Xamarin.Forms.Switch;
using SwitchRenderer = Xamarin.Forms.Platform.Android.AppCompat.SwitchRenderer;

[assembly: ExportRenderer(typeof(CustomSwitch), typeof(MySwitchRender))]

namespace InWhiter.Android
{
    public class MySwitchRender : SwitchRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Switch> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
                return;

            SwitchChange(null, null);

            Control.CheckedChange += SwitchChange;
        }

        private void SwitchChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            var switcher = Control as SwitchCompat;
            var mySwitch = (CustomSwitch)Element;

            if (Control.Checked)
            {
                switcher.ThumbDrawable.SetColorFilter(mySwitch.ThumbOnColor.ToAndroid(), PorterDuff.Mode.SrcAtop);
                switcher.TrackDrawable.SetColorFilter(mySwitch.TrackOnColor.ToAndroid(), PorterDuff.Mode.SrcAtop);
            }
            else
            {
                switcher.ThumbDrawable.SetColorFilter(mySwitch.ThumbOffColor.ToAndroid(), PorterDuff.Mode.SrcAtop);
                switcher.TrackDrawable.SetColorFilter(mySwitch.TrackOffColor.ToAndroid(), PorterDuff.Mode.SrcAtop);
            }
        }
    }
}