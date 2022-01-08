using Xamarin.Forms;

namespace InWhiter.Utilities
{
    public class MyTableView : TableView
    {
        public static readonly BindableProperty SeparatorColorProperty =
            BindableProperty.Create(nameof(SeparatorColor), typeof(Color), typeof(MyTableView), Color.White);

        public static readonly BindableProperty SeparatorHeightProperty =
            BindableProperty.Create(nameof(SeparatorHeight), typeof(int), typeof(MyTableView), 1);

        public static readonly BindableProperty GroupHeaderColorProperty =
            BindableProperty.Create(nameof(GroupHeaderColor), typeof(Color), typeof(MyTableView), Color.White);

        public static readonly BindableProperty GroupHeaderSeparatorColorProperty =
            BindableProperty.Create(nameof(GroupHeaderSeparatorColor), typeof(Color), typeof(MyTableView),
                Color.Transparent);

        /// <summary>
        /// Separator color. 
        /// Default is white color.
        /// </summary>
        public Color SeparatorColor
        {
            get => (Color)GetValue(SeparatorColorProperty);
            set => SetValue(SeparatorColorProperty, value);
        }

        /// <summary>
        /// Separator height
        /// Default is 1
        /// </summary>
        public int SeparatorHeight
        {
            get => (int)GetValue(SeparatorHeightProperty);
            set => SetValue(SeparatorHeightProperty, value);
        }

        /// <summary>
        /// Group header color
        /// Default is white color
        /// </summary>
        public Color GroupHeaderColor
        {
            get => (Color)GetValue(GroupHeaderColorProperty);
            set => SetValue(GroupHeaderColorProperty, value);
        }

        /// <summary>
        /// Group header separator color
        /// Default is transparent color
        /// </summary>
        public Color GroupHeaderSeparatorColor
        {
            get => (Color)GetValue(GroupHeaderSeparatorColorProperty);
            set => SetValue(GroupHeaderSeparatorColorProperty, value);
        }
    }
}