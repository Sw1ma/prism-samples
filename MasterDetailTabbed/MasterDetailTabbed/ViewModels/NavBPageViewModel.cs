using Prism.Commands;
using Prism.Navigation;

namespace MasterDetailTabbed.ViewModels
{
    public class NavBPageViewModel : BaseViewModel
    {
        public NavBPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Page B";
            NavigateCommand = new DelegateCommand(Navigate);
        }

        public DelegateCommand NavigateCommand { get; set; }
        private async void Navigate()
        {
            var result = await base.NavigationService.GoBackAsync();
            if (!result.Success)
            { }
        }
    }
}