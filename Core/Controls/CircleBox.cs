using Xamarin.Forms;

namespace Core.Controls
{
    public class CircleBox : BoxView
    {
        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create(
                nameof(CornerRadius), 
                typeof(double), 
                typeof(CircleBox), 
                0.0
            );
        
        public double CornerRadius
        {
            get { return (double)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
    }
}
