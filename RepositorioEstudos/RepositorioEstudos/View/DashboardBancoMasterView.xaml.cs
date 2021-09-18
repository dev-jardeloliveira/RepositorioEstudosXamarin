using RepositorioEstudos.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepositorioEstudos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardBancoMasterView : ContentPage
    {
        public DashboardBancoMasterView()
        {
            InitializeComponent();
            this.BindingContext = new DashboardBancoMasterViewModel();
        }
    }
}