using System;
using FFImageLoading.Forms;
using FFImageLoading.Transformations;

namespace Core.Controls
{
    public class WhatsAppImage : CachedImage
    {
        public WhatsAppImage()
        {
            WidthRequest = 60;
            HeightRequest = 60;
            DownsampleToViewSize = true;

            Transformations.Add(new CircleTransformation());
        }
    }
}
