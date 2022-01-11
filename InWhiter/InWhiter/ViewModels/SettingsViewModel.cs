using System;
using System.Windows.Input;
using InWhiter.Views;
using Xamarin.Forms;

namespace InWhiter.ViewModels
{
    public class SettingsViewModel : BaseVM
    {
        private bool _settingsViewIsEnabled = true;
        private bool _changePhotoProfileSelectorIsVisible = true;
        private bool _changePhotoProfileButtonIsVisible = true;

        public bool SettingsViewIsEnabled
        {
            get => _settingsViewIsEnabled;
            set => SetProperty(ref _settingsViewIsEnabled, value);
        }

        public bool ChangePhotoProfileSelectorIsVisible
        {
            get => _changePhotoProfileSelectorIsVisible;
            set => SetProperty(ref _changePhotoProfileSelectorIsVisible, value);
        }

        public bool ChangePhotoProfileButtonIsVisible
        {
            get => _changePhotoProfileButtonIsVisible;
            set => SetProperty(ref _changePhotoProfileButtonIsVisible, value);
        }


        public ICommand ChangePhotoProfileCommand
        {
            get
            {
                return new Command(() =>
                {
                    SettingsViewIsEnabled = false;
                    ChangePhotoProfileSelectorIsVisible = true;
                    ChangePhotoProfileButtonIsVisible = false;
                });
            }
        }

        public void SetDefaultState()
        {
            SettingsViewIsEnabled = true;
            ChangePhotoProfileSelectorIsVisible = false;
            ChangePhotoProfileButtonIsVisible = true;
        }

        public SettingsViewModel()
        {
            Title = "Settings";
        }
    }
}