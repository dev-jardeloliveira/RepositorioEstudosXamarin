using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using RepositorioEstudos.Custom;
using RepositorioEstudos.Droid.Custom;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryCustom), typeof(EntryAndroid))]
namespace RepositorioEstudos.Droid.Custom
{
    public class EntryAndroid:EntryRenderer
    {
        public EntryAndroid(Context context):base(context)
        {

        }
        public EntryCustom _custom => Element as EntryCustom;
        protected override FormsEditText CreateNativeControl()
        {
            var control = base.CreateNativeControl();
            UpdateBackground(control);
            return control;
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == EntryCustom.CornerRadiusProperty.PropertyName)
            {
                UpdateBackground();
            }
            else if (e.PropertyName == EntryCustom.BorderThicknessProperty.PropertyName)
            {
                UpdateBackground();
            }
            else if (e.PropertyName == EntryCustom.BorderColorProperty.PropertyName)
            {
                UpdateBackground();
            }

            base.OnElementPropertyChanged(sender, e);
        }
        

        protected void UpdateBackground(FormsEditText control)
        {
            if (control == null) return;

            var gd = new GradientDrawable();
            gd.SetColor(Element.BackgroundColor.ToAndroid());
            gd.SetCornerRadius(Context.ToPixels(_custom.CornerRadius));
            gd.SetStroke((int)Context.ToPixels(_custom.BorderThickness), _custom.BorderColor.ToAndroid());
            control.SetBackground(gd);

            var padTop = (int)Context.ToPixels(_custom.Padding.Top);
            var padBottom = (int)Context.ToPixels(_custom.Padding.Bottom);
            var padLeft = (int)Context.ToPixels(_custom.Padding.Left);
            var padRigth = (int)Context.ToPixels(_custom.Padding.Right);

            control.SetPadding(padLeft, padTop, padRigth, padBottom);
            if (!string.IsNullOrEmpty(_custom.Image))
            {
                switch (_custom.ImageAlignment)
                {
                    case ImageAlignment.Left:
                        control.SetCompoundDrawablesWithIntrinsicBounds(GetDrawable(_custom.Image), null, null, null);
                        break;
                    case ImageAlignment.Right:
                        control.SetCompoundDrawablesWithIntrinsicBounds(null, null, GetDrawable(_custom.Image), null);
                        break;

                }
            }
          

            control.CompoundDrawablePadding = 25;
           
        }
        private BitmapDrawable GetDrawable(string imageEntryImage)
        {
            int resID = Resources.GetIdentifier(imageEntryImage, "drawable", this.Context.PackageName);
            var drawable = ContextCompat.GetDrawable(this.Context, resID);
            var bitmap = ((BitmapDrawable)drawable).Bitmap;

            return new BitmapDrawable(Resources, Bitmap.CreateScaledBitmap(bitmap, _custom.ImageWidth * 2, _custom.ImageHeight * 2, true));
        }
        protected void UpdateBackground()
        {
            UpdateBackground(Control);
        }
    }
}