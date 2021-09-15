using RepositorioEstudos.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepositorioEstudos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormsView : ContentPage
    {
        public FormsView()
        {
            InitializeComponent();
            this.BindingContext = new FormsViewModel();
        }
    }
}