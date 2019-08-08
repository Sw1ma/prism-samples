using MasterDetailTabbed.Models;
using Prism.AppModel;
using Prism.Commands;
using Prism.Navigation;
using System.Collections.Generic;

namespace MasterDetailTabbed.ViewModels
{
    public class MasterPageViewModel : BaseViewModel, IPageLifecycleAware
    {
        public MasterPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        List<NavItem> _menuItems;
        public List<NavItem> MenuItems
        {
            get => _menuItems;
            set => SetProperty(ref _menuItems, value);
        }

        public DelegateCommand<string> NavigateCommand { get; set; }

        private async void Navigate(string target)
        {
            var path = NavigationService.GetNavigationUriPath();

            var result = await base.NavigationService.NavigateAsync(target);
            if (!result.Success)
            { }
        }

        public void OnAppearing()
        {
            if (MenuItems != null)
                return;

            var items = new List<NavItem>()
            {
                new NavItem { Title = "Tab A", Target = "Navigation/Tabbed?selectedTab=TabA" },
                new NavItem { Title = "Tab B", Target = "Navigation/Tabbed?selectedTab=TabB" },
                new NavItem { Title = "Tab C", Target = "Navigation/Tabbed?selectedTab=TabC" },
                new NavItem { Title = "Tab, Page A", Target = "Navigation/Tabbed/PageA" },
                new NavItem { Title = "Tab, Page B", Target = "Navigation/Tabbed/PageB" },
                new NavItem { Title = "Tab, Page A/B", Target = "Navigation/Tabbed/PageA/PageB" },
                new NavItem { Title = "Tab, Page A/B/A", Target = "Navigation/Tabbed/PageA/PageB/PageA" },
                new NavItem { Title = "Nav Page A", Target = "Navigation/PageA?args=false" }
            };

            MenuItems = new List<NavItem>(items);
        }

        public void OnDisappearing()
        { }
    }
}