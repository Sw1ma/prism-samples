using MasterDetailTabbed.Models;
using Prism.AppModel;
using Prism.Commands;
using Prism.Navigation;
using System.Collections.Generic;

namespace MasterDetailTabbed.ViewModels
{
    public class MasterPageViewModel : ViewModelBase, IPageLifecycleAware
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
            // View path of current page.
            var path = NavigationService.GetNavigationUriPath();

            var result = await NavigationService.NavigateAsync(target);
            if (!result.Success)
            {
                throw new System.Exception(result.Exception.Message);
            }
        }

        public void OnAppearing()
        {
            if (MenuItems != null)
                return;

            var items = new List<NavItem>()
            {
                new NavItem { Title = "Tab A", Target = "Tabbed?selectedTab=TabA" },
                new NavItem { Title = "Tab B", Target = "Tabbed?selectedTab=TabB" },
                new NavItem { Title = "Tab C", Target = "Tabbed?selectedTab=TabC" },
                new NavItem { Title = "Tab, Page A", Target = "Tabbed/PageA" },
                new NavItem { Title = "Tab, Page B", Target = "Tabbed/PageB" },
                new NavItem { Title = "Tab, Page A/B", Target = "Tabbed/PageA/PageB" },
                new NavItem { Title = "Tab, Page A/B/A", Target = "Tabbed/PageA/PageB/PageA" },
                new NavItem { Title = "Nav Page A w/ args", Target = "Navigation/PageA?args=false" }
            };

            MenuItems = new List<NavItem>(items);
        }

        public void OnDisappearing()
        { }
    }
}