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

        private void search_Focused(object sender, FocusEventArgs e)
        {
            pancake.Margin = new Thickness(0, 70, 0, 0);
        }

        private void search_Unfocused(object sender, FocusEventArgs e)
        {
            pancake.Margin = new Thickness(0, 240, 0, 0);
        }

      
    }
}