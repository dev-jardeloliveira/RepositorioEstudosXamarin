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
        public ICommand CustomCommand => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new ComponentesCustomView());
        });
        public ICommand CafeCommand => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new CafeView());
        });
        public ICommand GradientCommand => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new BackgroundGradient());
        });
        public ICommand FormularioCommand => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new FormsView());
        });
        public ICommand OnboardingCommand => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new OnboardingView());
        });
        #endregion
    }
}
