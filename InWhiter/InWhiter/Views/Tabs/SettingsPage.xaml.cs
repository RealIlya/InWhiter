using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InWhiter.ViewModels;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace InWhiter.Views.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        private double _oldY = 300;

        private double _UPPER_POINT = 700;
        private const double _LOWER_POINT = 100;

        private readonly DisplayInfo _displayInfo;
        

        public SettingsPage()
        {
            InitializeComponent();

            _displayInfo = DeviceDisplay.MainDisplayInfo;
        }

        private void PanGestureRecognizer_OnPanUpdated(object sender, EventArgs eventArgs)
        {
            // const double smoothFactor = 0.25;
            //
            // Debug.WriteLine($"Total Y is {e.TotalY}");
            //
            // var y = e.TotalY;
            //
            // y = smoothFactor * (y - _oldY);
            //
            // var height = Frame.HeightRequest + -1 * y;
            //
            // height = Math.Max(Math.Min(height, _displayInfo.Height), _LOWER_POINT);
            //
            // Frame.HeightRequest = height;
            //
            //
            // _oldY = y;
            //
            // if (e.StatusType is GestureStatus.Completed or GestureStatus.Canceled)
            // {
            //     var toUpper = Math.Abs(_UPPER_POINT - height);
            //     var toLower = Math.Abs(_LOWER_POINT - height);
            //
            //     if (toUpper < toLower)
            //         Frame.HeightRequest = _UPPER_POINT;
            //     else
            //     {
            //         Frame.HeightRequest = _LOWER_POINT;
            //         ((SettingsViewModel)BindingContext).SetDefaultState();
            //     }
            // }

            // void Callback(double input) => Frame.HeightRequest = input;
            //
            // const uint rate = 32;
            // const uint length = 1000;
            //
            // if ((int)Frame.HeightRequest == 50)
            // {
            //     Frame.Animate("AppearingAnim", Callback, 50, 500, rate, length, Easing.CubicOut);
            // }
            // else
            // {
            //     Frame.Animate("AppearingAnim", Callback, 500, 50, rate, length, Easing.SinOut);
            //
            // }
        }
    }
}