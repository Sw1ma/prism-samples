using MasterDetailTabbed.Mvvm;
using Prism.Navigation;

namespace MasterDetailTabbed.ViewModels
{
    public class BaseViewModel : ObservableObject, INavigationAware, IDestructible
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

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
            Parameters = parameters;
        }
        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
            Parameters = parameters;
        }
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