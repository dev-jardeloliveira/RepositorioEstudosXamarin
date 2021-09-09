using RepositorioEstudos.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepositorioEstudos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FontesView : ContentPage
    {
        public FontesView()
        {
            InitializeComponent();
            this.BindingContext = new FontesViewModel();
        }
    }
}