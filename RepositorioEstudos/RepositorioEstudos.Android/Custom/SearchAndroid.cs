using Android.Content;
using Android.Support.V4.Content;
using RepositorioEstudos.Custom;
using RepositorioEstudos.Droid.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(SearchBarCustom),typeof(SearchAndroid))]
namespace RepositorioEstudos.Droid.Custom
{
    public class SearchAndroid:SearchBarRenderer
    {
        Context _context;
        public SearchAndroid(Context context):base(context)
        {
            _context = context;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                var plateId = Resources.GetIdentifier("android:id/search_plate", null, null);
                var plate = Control.FindViewById(plateId);
                plate.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }
              
        }
    }
}