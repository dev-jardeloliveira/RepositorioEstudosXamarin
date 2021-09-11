using RepositorioEstudos.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepositorioEstudos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CafeView : ContentPage
    {
        public CafeView()
        {
            InitializeComponent();
            this.BindingContext = new CafeViewModel();
        }
    }
}