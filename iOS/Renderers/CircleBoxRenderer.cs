using System.ComponentModel;
using Core.Controls;
using Core.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CircleBox), typeof(CircleBoxRenderer))]
namespace Core.iOS.Renderers
{
    /// <summary>
    /// Referências: 
    /// - https://julianocustodio.com/2017/11/10/badgeview/
    /// </summary>
    public class CircleBoxRenderer : BoxRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);

            if (Element != null)
            {
                Layer.MasksToBounds = true;
                UpdateCornerRadius(Element as CircleBox);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == CircleBox.CornerRadiusProperty.PropertyName)
            {
                UpdateCornerRadius(Element as CircleBox);
            }
        }

        void UpdateCornerRadius(CircleBox box)
        {
            Layer.CornerRadius = (float)box.CornerRadius;
        }
    }
}
