using System.Collections.Generic;
using Core.Models;

namespace Core.Interfaces
{
    public interface INubank
    {
        IList<NubankTimelineModel> GetTimeline();
    }
}
