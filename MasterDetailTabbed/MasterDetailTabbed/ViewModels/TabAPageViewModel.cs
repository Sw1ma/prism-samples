using Prism.Navigation;

namespace MasterDetailTabbed.ViewModels
{
    public class TabAPageViewModel : BaseViewModel
    {
        public TabAPageViewModel(INavigationService naigationService) : base(naigationService)
        {
            Title = "Tab A";
        }
    }
}
