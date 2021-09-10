using CoreGraphics;
using Foundation;
using RepositorioEstudos.Custom;
using RepositorioEstudos.iOS.Custom;
using System.ComponentModel;
using System.Drawing;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly:ExportRenderer(typeof(EntryCustom),typeof(EntryIOS))]
namespace RepositorioEstudos.iOS.Custom
{
    public class EntryIOS:EntryRenderer
    {
        public EntryCustom _custom => Element as EntryCustom;
        public UITextFieldPadding ControlV2 => Control as UITextFieldPadding;
        protected override UITextField CreateNativeControl()
        {
            var control = new UITextFieldPadding(RectangleF.Empty)
            {
                Padding = _custom.Padding,
                BorderStyle = UITextBorderStyle.RoundedRect,
                ClipsToBounds = true
            };

            UpdateBackground(control);

            return control;
        }

        protected void UpdateBackground(UITextField control)
        {
            if (control == null) return;
            control.Layer.CornerRadius = _custom.CornerRadius;
            control.Layer.BorderWidth = _custom.BorderThickness;
            control.Layer.BorderColor = _custom.BorderColor.ToCGColor();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == EntryCustom.PaddingProperty.PropertyName)
            {
                UpdatePadding();
            }

            base.OnElementPropertyChanged(sender, e);
        }

        protected void UpdatePadding()
        {
            if (Control == null)
                return;

            ControlV2.Padding = _custom.Padding;
        }
    }
    public class UITextFieldPadding : UITextField
    {
        private Thickness _padding = new Thickness(5);

        public Thickness Padding
        {
            get => _padding;
            set
            {
                if (_padding != value)
                {
                    _padding = value;
                    //InvalidateIntrinsicContentSize();
                }
            }
        }

        public UITextFieldPadding()
        {
        }
        public UITextFieldPadding(NSCoder coder) : base(coder)
        {
        }

        public UITextFieldPadding(CGRect rect) : base(rect)
        {
        }

        public override CGRect TextRect(CGRect forBounds)
        {
            var insets = new UIEdgeInsets((float)Padding.Top, (float)Padding.Left, (float)Padding.Bottom, (float)Padding.Right);
            return insets.InsetRect(forBounds);
        }

        public override CGRect PlaceholderRect(CGRect forBounds)
        {
            var insets = new UIEdgeInsets((float)Padding.Top, (float)Padding.Left, (float)Padding.Bottom, (float)Padding.Right);
            return insets.InsetRect(forBounds);
        }

        public override CGRect EditingRect(CGRect forBounds)
        {
            var insets = new UIEdgeInsets((float)Padding.Top, (float)Padding.Left, (float)Padding.Bottom, (float)Padding.Right);
            return insets.InsetRect(forBounds);
        }
    }
}