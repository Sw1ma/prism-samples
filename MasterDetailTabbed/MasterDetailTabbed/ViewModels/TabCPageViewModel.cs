using Prism.Navigation;

namespace MasterDetailTabbed.ViewModels
{
    public class TabCPageViewModel : BaseViewModel
    {
        public TabCPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Tab C";
        }
    }
}
