using Prism.Navigation;

namespace MasterDetailTabbed.ViewModels
{
    public class TabCPageViewModel : BaseViewModel
    {
        public TabCPageViewModel(INavigationService naigationService) : base(naigationService)
        {
            Title = "Tab C";
        }
    }
}
