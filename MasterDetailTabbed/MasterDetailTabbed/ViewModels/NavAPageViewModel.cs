using Prism.AppModel;
using Prism.Commands;
using Prism.Navigation;
using System;

namespace MasterDetailTabbed.ViewModels
{
    public class NavAPageViewModel : ViewModelBase, IPageLifecycleAware
    {
        public NavAPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Page A";
            NavigateCommand = new DelegateCommand(Navigate);
        }

        bool _isVisible = true;
        public bool IsVisible
        {
            get => _isVisible;
            set => SetProperty(ref _isVisible, value);
        }

        public DelegateCommand NavigateCommand { get; set; }
        private async void Navigate()
        {
            var result = await base.NavigationService.GoBackAsync();
            if (!result.Success)
            { }
        }

        [Obsolete("OnNavigatedTo is deprecated by Prism w/ release 7.2.0.1367, please implement IPageLifecycleAware instead.")]
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (Parameters.ContainsKey("args")) {
                IsVisible = Parameters.GetValue<bool>("args");
            }
        }

        public void OnAppearing()
        {
            if (Parameters.ContainsKey("args")) {
                IsVisible = Parameters.GetValue<bool>("args");
            }
        }

        public void OnDisappearing()
        { }
    }
}