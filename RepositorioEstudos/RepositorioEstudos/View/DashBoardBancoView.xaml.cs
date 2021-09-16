using RepositorioEstudos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepositorioEstudos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoardBancoView : ContentPage
    {
        public DashBoardBancoView()
        {
            InitializeComponent();
            this.BindingContext = new DashBoardBancoViewModel();
        }
    }
}