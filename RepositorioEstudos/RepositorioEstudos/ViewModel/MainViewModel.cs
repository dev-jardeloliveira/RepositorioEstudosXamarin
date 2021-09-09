using RepositorioEstudos.View;
using System.Windows.Input;
using Xamarin.Forms;

namespace RepositorioEstudos.ViewModel
{
    public class MainViewModel
    {
        #region Campos
        public ICommand QrCodeCommand => new Command(async () =>
        {            
            await App.Current.MainPage.Navigation.PushAsync(new QrCodeView());
        });
        public ICommand FontCommand => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new FontesView());
        });
        #endregion
    }
}
