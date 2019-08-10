using Prism.Navigation;

namespace MasterDetailTabbed.ViewModels
{
    public class TabBPageViewModel : BaseViewModel
    {
        public TabBPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Tab B";
        }
    }
}
