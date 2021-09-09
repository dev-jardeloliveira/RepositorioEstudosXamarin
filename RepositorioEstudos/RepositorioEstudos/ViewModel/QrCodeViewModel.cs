using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace RepositorioEstudos.ViewModel
{
    public class QrCodeViewModel
    {
        #region Campos
        
        public ICommand ScannerCommand => new Command(async () =>
        {
            await Abrir();
        });
        #endregion
        #region Métodos
        private async Task Abrir()
        {
           

            var scanner = new ZXing.Mobile.MobileBarcodeScanner();
            var result = await scanner.Scan();
            if(result != null)
            {
                if(await Launcher.CanOpenAsync(new Uri(result.Text)))
                    await Launcher.OpenAsync(new Uri(result.Text));
            }
           

        }
        #endregion
    }
}
