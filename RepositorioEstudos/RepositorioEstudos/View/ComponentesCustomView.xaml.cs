using RepositorioEstudos.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepositorioEstudos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesCustomView : ContentPage
    {
        public ComponentesCustomView()
        {
            InitializeComponent();
            this.BindingContext = new ComponentesCustomViewModel();
        }
    }
}