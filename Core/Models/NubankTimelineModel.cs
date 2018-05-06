using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class NubankTimelineModel
    {
        public string Category { get; set; }
        public string CategoryIcon { get; set; }
        public string TextColor { get; set; }
        public string Description { get; set; }
        public double? LocalPrice { get; set; }
        public bool IsDollar { get; set; }
        public double? DollarPrice { get; set; }
        public bool IsInstallment { get; set; }
        public int? NumberOfInstallments { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public bool IsReversed { get; set; }
        public IList<string> Tags { get; set; }

        public NubankTimelineModel()
        {
            Tags = new List<string>();
        }
    }
}
