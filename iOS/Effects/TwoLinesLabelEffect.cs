using System;
using Core.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("App")]
[assembly: ExportEffect(typeof(TwoLinesLabelEffect), nameof(TwoLinesLabelEffect))]
namespace Core.iOS.Effects
{
    public class TwoLinesLabelEffect : PlatformEffect
    {
        private UILabel _control;

        protected override void OnAttached()
        {
            try
            {
                _control = Control as UILabel;
                _control.LineBreakMode = UILineBreakMode.TailTruncation;
                _control.Lines = 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Cannot set property on attached control. Error: {ex.Message}");
            }
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}
