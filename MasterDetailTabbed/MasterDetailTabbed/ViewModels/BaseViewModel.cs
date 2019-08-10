using MasterDetailTabbed.Mvvm;
using Prism.Navigation;
using System;

/* Release notes
 * -------------
 * 08/10/2019 13:45
 * Updated to Prism release v7.2.0.1367
 * https://github.com/PrismLibrary/Prism/releases/tag/v7.2.0.1367
 * [Enhancement] Implement IInitialize (BREAKING) #1748
 * https://github.com/PrismLibrary/Prism/issues/1748 */

namespace MasterDetailTabbed.ViewModels
{
    public class BaseViewModel : ObservableObject, IInitialize, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }
        protected INavigationParameters Parameters { get; set; }

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                SetProperty(ref _isBusy, value, onChanged: ()
                    => OnPropertyChanged(nameof(IsNotBusy)));
            }
        }
        public bool IsNotBusy
        {
            get => !IsBusy;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {
            Parameters = parameters;
        }

        [Obsolete("OnNavigatedFrom is deprecated by Prism w/ release 7.2.0.1367, please implement IInitialize instead.")]
        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
            Parameters = parameters;
        }

        [Obsolete("OnNavigatedTo is deprecated by Prism w/ release 7.2.0.1367, please implement IInitialize instead.")]
        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
            Parameters = parameters;
        }

        [Obsolete("OnNavigatingTo is deprecated by Prism w/ release 7.2.0.1367, please implement IInitialize instead.")]
        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {
            Parameters = parameters;
        }

        public virtual void Destroy()
        {
            NavigationService = null;
            Parameters = null;
        }
    }
}