using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailTabbed.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : IMasterDetailPageOptions
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        public bool IsPresentedAfterNavigation => Device.Idiom != TargetIdiom.Phone;
    }
}