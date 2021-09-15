using RepositorioEstudos.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepositorioEstudos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BackgroundGradient : ContentPage
    {
        public BackgroundGradient()
        {
            InitializeComponent();
            this.BindingContext = new BackgroundGradientViewModel();
        }
    }
}