using MasterDetailTabbed.ViewModels;
using MasterDetailTabbed.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;

namespace MasterDetailTabbed
{
    public partial class App
    {
        public App() : this(null)
        { }
        public App(IPlatformInitializer initializer) : base(initializer)
        { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            //MainPage = new MasterPage();
            NavigationService.NavigateAsync("/Master/Navigation/Tabbed?selectedTab=TabB");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>("Navigation");
            containerRegistry.RegisterForNavigation<MasterPage, MasterPageViewModel>("Master");
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>("Tabbed");
            containerRegistry.RegisterForNavigation<TabAPage, TabAPageViewModel>("TabA");
            containerRegistry.RegisterForNavigation<TabBPage, TabBPageViewModel>("TabB");
            containerRegistry.RegisterForNavigation<TabCPage, TabCPageViewModel>("TabC");
            containerRegistry.RegisterForNavigation<NavAPage, NavAPageViewModel>("PageA");
            containerRegistry.RegisterForNavigation<NavBPage, NavBPageViewModel>("PageB");
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}