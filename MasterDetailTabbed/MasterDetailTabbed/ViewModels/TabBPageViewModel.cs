using Prism.Navigation;

namespace MasterDetailTabbed.ViewModels
{
    public class TabBPageViewModel : BaseViewModel
    {
        public TabBPageViewModel(INavigationService naigationService) : base(naigationService)
        {
            Title = "Tab B";
        }
    }
}
