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
    public partial class QrCodeView : ContentPage
    {
        public QrCodeView()
        {
            InitializeComponent();
            this.BindingContext = new QrCodeViewModel();
        }
    }
}