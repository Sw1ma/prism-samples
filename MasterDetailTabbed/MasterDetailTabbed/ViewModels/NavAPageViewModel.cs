using Prism.Commands;
using Prism.Navigation;
using System;

namespace MasterDetailTabbed.ViewModels
{
    public class NavAPageViewModel : BaseViewModel
    {
        public NavAPageViewModel(INavigationService naigationService) : base(naigationService)
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

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (Parameters.ContainsKey("args")) {
                IsVisible = Parameters.GetValue<bool>("args");
            }
        }
    }
}