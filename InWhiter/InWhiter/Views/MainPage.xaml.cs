using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using InWhiter.Views.Tabs;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace InWhiter.Views
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));

            BindingContext = this;
        }
        public ICommand ToSettingsCommand => new Command(async () =>
        {
            Shell.Current.FlyoutIsPresented = false;
            await Shell.Current.GoToAsync($"{nameof(SettingsPage)}");
        });
    }
}