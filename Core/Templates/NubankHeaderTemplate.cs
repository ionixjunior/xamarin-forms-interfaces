using System;
using Core.Models.Nubank;
using Core.Templates.Nubank;
using Xamarin.Forms;

namespace Core.Templates
{
    public class NubankHeaderTemplate : DataTemplateSelector
    {
        private DataTemplate _summary;
        private DataTemplate _invoice;

        public NubankHeaderTemplate()
        {
            _summary = new DataTemplate(typeof(HeaderSummary));
            _invoice = new DataTemplate(typeof(HeaderInvoice));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var header = item as NubankHeaderModel;

            if (header is NubankHeaderSummaryModel)
                return _summary;

            if (header is NubankHeaderInvoiceModel)
                return _invoice;

            return null;
        }
    }
}
