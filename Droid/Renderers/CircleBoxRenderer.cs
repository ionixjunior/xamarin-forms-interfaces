using System.ComponentModel;
using Android.Content;
using Android.Graphics;
using Core.Controls;
using Core.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CircleBox), typeof(CircleBoxRenderer))]
namespace Core.Droid.Renderers
{
    /// <summary>
    /// Referências: 
    /// - https://julianocustodio.com/2017/11/10/badgeview/
    /// </summary>
    public class CircleBoxRenderer : BoxRenderer
    {
        public CircleBoxRenderer(Context context) : base(context) {}

        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);
            SetWillNotDraw(false);
            Invalidate();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == CircleBox.CornerRadiusProperty.PropertyName)
            {
                Invalidate();
            }
        }

        public override void Draw(Canvas canvas)
        {
            var box = Element as CircleBox;

            var rect = new Rect();
            var paint = new Paint()
            {
                Color = box.BackgroundColor.ToAndroid(),
                AntiAlias = true,
            };

            GetDrawingRect(rect);

            var radius = (float)(rect.Width() / box.Width * box.CornerRadius);

            canvas.DrawRoundRect(new RectF(rect), radius, radius, paint);
        }
    }
}
