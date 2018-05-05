using System;
using Core.Controls;
using Core.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AlwaysScrollView), typeof(AlwaysScrollViewRenderer))]
namespace Core.iOS.Renderers
{
    public class AlwaysScrollViewRenderer : ScrollViewRenderer
    {
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
            base.OnElementChanged(e);
            AlwaysBounceVertical = true;
		}
	}
}
