using Prism.Navigation;

namespace MasterDetailTabbed.ViewModels
{
    public class TabAPageViewModel : ViewModelBase
    {
        public TabAPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Tab A";
        }
    }
}
