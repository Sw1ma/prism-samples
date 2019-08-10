using Prism.Navigation;

namespace MasterDetailTabbed.ViewModels
{
    public class TabAPageViewModel : BaseViewModel
    {
        public TabAPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Tab A";
        }
    }
}
