using System;
using Android.Text;
using Android.Widget;
using Core.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("App")]
[assembly: ExportEffect(typeof(TwoLinesLabelEffect), nameof(TwoLinesLabelEffect))]
namespace Core.Droid.Effects
{
    public class TwoLinesLabelEffect : PlatformEffect
    {
        private TextView _control;

        protected override void OnAttached()
        {
            try
            {
                _control = Control as TextView;
                _control.Ellipsize = TextUtils.TruncateAt.End;
                _control.SetMaxLines(2);
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
