using Microcharts;

namespace Core.Models.Nubank
{
    public class NubankHeaderSummaryModel : NubankHeaderModel
    {
        public LineChart Chart { get; set; }
        public string Description { get; set; }
    }
}
