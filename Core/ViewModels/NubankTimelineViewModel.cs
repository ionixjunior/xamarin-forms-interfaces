using System;
using System.Collections.ObjectModel;
using Core.Interfaces;
using Core.Models;

namespace Core.ViewModels
{
    public class NubankTimelineViewModel : BaseViewModel
    {
        private readonly INubank _nubank;

        public ObservableCollection<NubankTimelineModel> Items { get; set; }

        public NubankTimelineViewModel(INubank nubank)
        {
            Items = new ObservableCollection<NubankTimelineModel>(
                nubank.GetTimeline()
            );
        }
    }
}
