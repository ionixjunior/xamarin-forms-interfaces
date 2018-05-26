using System;
using System.Collections.ObjectModel;
using Core.Interfaces;
using Core.Models;
using Core.Models.Nubank;

namespace Core.ViewModels
{
    public class NubankTimelineViewModel : BaseViewModel
    {
        public ObservableCollection<NubankHeaderModel> Headers { get; set; }
        public ObservableCollection<NubankTimelineModel> Items { get; set; }

        public NubankTimelineViewModel(INubank nubank)
        {
            Headers = new ObservableCollection<NubankHeaderModel>(
                nubank.GetHeader()
            );

            Items = new ObservableCollection<NubankTimelineModel>(
                nubank.GetTimeline()
            );
        }
    }
}
