using System.Collections.Generic;
using Core.Models;
using Core.Models.Nubank;

namespace Core.Interfaces
{
    public interface INubank
    {
        IList<NubankHeaderModel> GetHeader();
        IList<NubankTimelineModel> GetTimeline();
    }
}
