using Plugin.Media;
using Plugin.Media.Abstractions;
using System.Windows.Input;
using Xamarin.Forms;

namespace RepositorioEstudos.ViewModel
{
    public class OcrViewModel
    {
        #region campos
        public ICommand CapturarImagemComand = new Command(async () =>
        {


        });
        #endregion
        #region contrutor
        public OcrViewModel()
        {
            //OcrResults text;
            //var client = new VisionServiceClient("{YOUR-API-KEY-HERE}");
            //using (var photoStream = photo.GetStream())
            //{
            //    text = await client.RecognizeTextAsync(photoStream);
            //}
        }
        #endregion
        #region método
        private async void CapturarImagem()
        {
            await CrossMedia.Current.Initialize();
            MediaFile photo;
            if (CrossMedia.Current.IsCameraAvailable)
            {
                photo = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    Directory = "Invoices",
                    Name = "Invoice.jpg"
                });
            }
            else
            {
                photo = await CrossMedia.Current.PickPhotoAsync();
            }
        }
        #endregion
    }
}
