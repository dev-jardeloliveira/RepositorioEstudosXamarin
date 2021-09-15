using RepositorioEstudos.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepositorioEstudos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OcrView : ContentPage
    {
        public OcrView()
        {
            InitializeComponent();
            this.BindingContext = new OcrViewModel();
        }
    }
}