using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Core.Controls
{
    public class HorizontalViewNative : View
    {
        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create("ItemsSource", typeof(IEnumerable), typeof(HorizontalViewNative), default(IEnumerable<object>), BindingMode.TwoWay, propertyChanged: ItemsSourceChanged);

        public static readonly BindableProperty ItemTemplateProperty =
            BindableProperty.Create("ItemTemplate", typeof(DataTemplate), typeof(HVScrollGridView), default(DataTemplate));

        public static readonly BindableProperty ItemHeightProperty =
            BindableProperty.Create("ItemHeight", typeof(int), typeof(HVScrollGridView), default(int));

        public static readonly BindableProperty ItemWidthProperty =
            BindableProperty.Create("ItemWidth", typeof(int), typeof(HVScrollGridView), default(int));

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }

        public int ItemHeight
        {
            get { return (int)GetValue(ItemHeightProperty); }
            set { SetValue(ItemHeightProperty, value); }
        }

        public int ItemWidth
        {
            get { return (int)GetValue(ItemWidthProperty); }
            set { SetValue(ItemWidthProperty, value); }
        }

        private static void ItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var itemsLayout = (HorizontalViewNative)bindable;
        }
    }
}
