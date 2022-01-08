using System;
using System.ComponentModel;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;
using InWhiter.Android;
using InWhiter.Utilities;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Switch = Android.Widget.Switch;

[assembly: ExportRenderer(typeof(MyTableView), typeof(MyTableViewRenderer))]

namespace InWhiter.Android
{
    public class MyTableViewRenderer : TableViewRenderer
    {
        public MyTableViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TableView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
                return;

            //var listView = Control as global::Android.Widget.ListView;
            //listView.Divider = new ColorDrawable(Android.Graphics.Color.Transparent);
            //listView.DividerHeight = 0;

            SeparatorChange();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == "SeparatorColor")
                SeparatorChange();
        }

        protected override TableViewModelRenderer GetModelRenderer(global::Android.Widget.ListView listView,
            TableView view)
        {
            return new CustomHeaderTableViewModelRenderer(Context, listView, view);
        }

        private void SeparatorChange()
        {
            var listView = Control as global::Android.Widget.ListView;
            var myTableView = (MyTableView)Element;
            listView.Divider.SetTint(Color.Orange.GetHashCode());
            listView.Divider = new ColorDrawable(myTableView.SeparatorColor.ToAndroid());
            listView.DividerHeight = myTableView.SeparatorHeight;
        }

        private class CustomHeaderTableViewModelRenderer : TableViewModelRenderer
        {
            private readonly MyTableView _myTableView;

            public CustomHeaderTableViewModelRenderer(Context context, global::Android.Widget.ListView listView,
                TableView view) : base(context, listView, view)
            {
                _myTableView = view as MyTableView;
            }

            public override global::Android.Views.View GetView(int position, global::Android.Views.View convertView,
                ViewGroup parent)
            {
                var view = base.GetView(position, convertView, parent);

                var element = GetCellForPosition(position);

                if (element.GetType() == typeof(TextCell) && (element as TextCell)?.Detail == null)
                {
                    try
                    {
                        var textView =
                            (((view as LinearLayout)?.GetChildAt(0) as LinearLayout)?.GetChildAt(1) as LinearLayout)
                            ?.GetChildAt(0) as TextView;

                        var divider = (view as LinearLayout)?.GetChildAt(1);

                        textView.SetTextColor(_myTableView.GroupHeaderColor.ToAndroid());
                        textView.TextAlignment = global::Android.Views.TextAlignment.Center;
                        textView.Gravity = GravityFlags.Left;
                        divider.SetBackgroundColor(_myTableView.GroupHeaderSeparatorColor.ToAndroid());
                    }
                    catch (Exception)
                    {
                    }
                }
                // if (element.GetType() == typeof(SwitchCell))
                // {
                //     try
                //     {
                //         var switcher =
                //             (((view as LinearLayout)?.GetChildAt(0) as LinearLayout)?.GetChildAt(1) as LinearLayout)
                //             ?.GetChildAt(0) as Switch;
                //
                //         if (switcher.Checked)
                //             switcher.SplitTrack = true;
                //         else
                //             switcher.SplitTrack = false;
                //     }
                //     catch (Exception)
                //     {
                //     }
                // }

                return view;
            }
        }
    }
}