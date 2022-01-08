using Xamarin.Forms;

namespace InWhiter.Utilities
{
    public class CustomSwitch : Switch
    {
        #region Properties

        public static readonly BindableProperty ThumbOnColorProperty =
            BindableProperty.Create(nameof(ThumbOnColor), typeof(Color), typeof(CustomSwitch), Color.Black);

        public Color ThumbOnColor
        {
            get => (Color)GetValue(ThumbOnColorProperty);
            set => SetValue(ThumbOnColorProperty, value);
        }

        public static readonly BindableProperty ThumbOffColorProperty =
            BindableProperty.Create(nameof(ThumbOffColor), typeof(Color), typeof(CustomSwitch), Color.Gray);

        public Color ThumbOffColor
        {
            get => (Color)GetValue(ThumbOffColorProperty);
            set => SetValue(ThumbOffColorProperty, value);
        }

        public static readonly BindableProperty TrackOnColorProperty =
            BindableProperty.Create(nameof(TrackOnColor), typeof(Color), typeof(CustomSwitch), Color.Gray);

        public Color TrackOnColor
        {
            get => (Color)GetValue(TrackOnColorProperty);
            set => SetValue(TrackOnColorProperty, value);
        }

        public static readonly BindableProperty TrackOffColorProperty =
            BindableProperty.Create(nameof(TrackOffColor), typeof(Color), typeof(CustomSwitch), Color.LightGray);

        public Color TrackOffColor
        {
            get => (Color)GetValue(TrackOffColorProperty);
            set => SetValue(TrackOffColorProperty, value);
        }

        #endregion
    }
}