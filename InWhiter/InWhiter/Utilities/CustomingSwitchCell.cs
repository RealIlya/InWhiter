using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace InWhiter.Utilities
{
    /// <summary>
    /// Height default is 50
    /// </summary>
    public class CustomingSwitchCell : ViewCell
    {
        public readonly List<Grid> TypeViews = new List<Grid>();

        public readonly Grid FirstView;
        public readonly Grid SecondView;

        public Label HeaderLabel { get; set; }

        public CustomSwitch Switcher { get; set; }

        public CustomingSwitchCell()
        {
            Height = 50;

            HeaderLabel = new Label
            {
                FontSize = 14,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center
            };


            Switcher = new CustomSwitch();

            var stackLayout = new StackLayout { Children = { HeaderLabel } };
            // stackLayout.GestureRecognizers.Add();
            var gridPadding = new Thickness(20, 0, 10, 0);

            FirstView = (new Grid
            {
                Padding = gridPadding,
                ColumnDefinitions = { new() { Width = GridLength.Auto }, new() { Width = GridLength.Star } },
                Children = { { Switcher, 0, 0 }, { stackLayout, 1, 0 } }
            });

            SecondView = (new Grid
            {
                Padding = gridPadding,
                ColumnDefinitions = { new() { Width = GridLength.Star }, new() { Width = GridLength.Auto } },
                Children = { { Switcher, 1, 0 }, { stackLayout, 0, 0 } }
            });

            

            View = new Grid() { Children = { new Label() { Text = "Ничего с конструктора" } } };
        }

        #region Properties

        #region TextProperties

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomingSwitchCell), "", propertyChanged:
                (bindable, _, newValue) => ((CustomingSwitchCell)bindable).HeaderLabel.Text ??= (string)newValue);

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(CustomingSwitchCell),
                propertyChanged:
                (bindable, _, newValue) => ((CustomingSwitchCell)bindable).HeaderLabel.TextColor = (Color)newValue);

        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        /*
        public static readonly BindableProperty DetailProperty =
            BindableProperty.Create(nameof(Detail), typeof(string), typeof(CustomingSwitchCell), "", propertyChanged:
                (bindable, _, newValue) => ((CustomingSwitchCell)bindable).DetailLabel.Text ??= (string)newValue);


        public string Detail
        {
            get => (string)GetValue(DetailProperty);
            set => SetValue(DetailProperty, value);
        }
        
        public static readonly BindableProperty DetailColorProperty =
            BindableProperty.Create(nameof(DetailColor), typeof(Color), typeof(CustomingSwitchCell), Color.Gray,
                propertyChanged:
                (bindable, _, newValue) => ((CustomingSwitchCell)bindable).DetailLabel.TextColor = (Color)newValue);

        public Color DetailColor
        {
            get => (Color)GetValue(DetailColorProperty);
            set => SetValue(DetailColorProperty, value);
        }
        */

        #endregion

        #region SwitchProperties

        public static readonly BindableProperty ThumbOnColorProperty =
            BindableProperty.Create(nameof(ThumbOnColor), typeof(Color), typeof(CustomingSwitchCell), propertyChanged:
                (bindable, _, newValue) => ((CustomingSwitchCell)bindable).Switcher.ThumbOnColor = (Color)newValue);

        public Color ThumbOnColor
        {
            get => (Color)GetValue(ThumbOnColorProperty);
            set => SetValue(ThumbOnColorProperty, value);
        }

        public static readonly BindableProperty ThumbOffColorProperty =
            BindableProperty.Create(nameof(ThumbOffColor), typeof(Color), typeof(CustomingSwitchCell), propertyChanged:
                (bindable, _, newValue) => ((CustomingSwitchCell)bindable).Switcher.ThumbOffColor = (Color)newValue);

        public Color ThumbOffColor
        {
            get => (Color)GetValue(ThumbOffColorProperty);
            set => SetValue(ThumbOffColorProperty, value);
        }

        public static readonly BindableProperty TrackOnColorProperty =
            BindableProperty.Create(nameof(TrackOnColor), typeof(Color), typeof(CustomingSwitchCell), propertyChanged:
                (bindable, _, newValue) => ((CustomingSwitchCell)bindable).Switcher.TrackOnColor = (Color)newValue);

        public Color TrackOnColor
        {
            get => (Color)GetValue(TrackOnColorProperty);
            set => SetValue(TrackOnColorProperty, value);
        }

        public static readonly BindableProperty TrackOffColorProperty =
            BindableProperty.Create(nameof(TrackOffColor), typeof(Color), typeof(CustomingSwitchCell), propertyChanged:
                (bindable, _, newValue) => ((CustomingSwitchCell)bindable).Switcher.TrackOffColor = (Color)newValue);

        public Color TrackOffColor
        {
            get => (Color)GetValue(TrackOffColorProperty);
            set => SetValue(TrackOffColorProperty, value);
        }

        public static readonly BindableProperty SwitchOrientationProperty =
            BindableProperty.Create(nameof(SwitchOrientation), typeof(SwitchOptions), typeof(CustomingSwitchCell),
                propertyChanged: (bindable, _, newValue) =>
                {
                    var cell = (CustomingSwitchCell)bindable;

                    cell.View = (SwitchOptions)newValue switch
                    {
                        SwitchOptions.Left => cell.FirstView,
                        SwitchOptions.Right => cell.SecondView,
                        _ => new Grid() { Children = { new Label() { Text = "Ничего со свойства" } } }
                    };
                });

        public SwitchOptions SwitchOrientation
        {
            get => (SwitchOptions)GetValue(SwitchOrientationProperty);
            set => SetValue(SwitchOrientationProperty, value);
        }

        #endregion

        #endregion
    }

    public enum SwitchOptions
    {
        Left = 1,
        Right = 2
    }
}