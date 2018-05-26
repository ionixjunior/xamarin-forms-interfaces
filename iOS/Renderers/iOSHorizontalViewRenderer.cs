using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Core.Controls;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Core.iOS.Renderers;

[assembly: ExportRenderer(typeof(HorizontalViewNative), typeof(iOSHorizontalViewRenderer))]
namespace Core.iOS.Renderers
{
    public class iOSHorizontalViewRenderer : ViewRenderer<HorizontalViewNative, UICollectionView>
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(HorizontalViewNative.ItemsSource))
            {
                Control.DataSource = new iOSViewSource(Element as HorizontalViewNative);
                Control.RegisterClassForCell(typeof(iOSViewCell), nameof(iOSViewCell));
            }
        }

        protected override void OnElementChanged(ElementChangedEventArgs<HorizontalViewNative> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var layout = new UICollectionViewFlowLayout();
                layout.ScrollDirection = UICollectionViewScrollDirection.Horizontal;

                if (e.NewElement != null)
                {
                    layout.ItemSize = new CGSize(e.NewElement.ItemWidth, e.NewElement.ItemHeight);
                    layout.MinimumInteritemSpacing = 0;
                    layout.MinimumLineSpacing = 0;

                    var rect = new CGRect(0, 0, 100, 100);
                    SetNativeControl(new UICollectionView(rect, layout));
                    Control.BackgroundColor = e.NewElement?.BackgroundColor.ToUIColor();
                }
            }
        }
    }


    public class iOSViewSource : UICollectionViewDataSource
    {
        private readonly HorizontalViewNative _view;

        private readonly IList _dataSource;

        public iOSViewSource(HorizontalViewNative view)
        {
            _view = view;
            _dataSource = view.ItemsSource?.Cast<object>()?.ToList();
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return _dataSource != null ? _dataSource.Count : 0;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            iOSViewCell cell = (iOSViewCell)collectionView.DequeueReusableCell(nameof(iOSViewCell), indexPath);
            var dataContext = _dataSource[indexPath.Row];
            if (dataContext != null)
            {
                var dataTemplate = _view.ItemTemplate;
                ViewCell viewCell;
                var selector = dataTemplate as DataTemplateSelector;
                if (selector != null)
                {
                    var template = selector.SelectTemplate(_dataSource[indexPath.Row], _view.Parent);
                    viewCell = template.CreateContent() as ViewCell;
                }
                else
                {
                    viewCell = dataTemplate?.CreateContent() as ViewCell;
                }

                cell.UpdateUi(viewCell, dataContext, _view);
            }
            return cell;
        }
    }

    public class iOSViewCell : UICollectionViewCell
    {
        public iOSViewCell(IntPtr p) : base(p)
        {
        }

        public void UpdateUi(ViewCell viewCell, object dataContext, HorizontalViewNative view)
        {
            viewCell.BindingContext = dataContext;
            viewCell.Parent = view;

            var height = (int)((view.ItemHeight + viewCell.View.Margin.Top + viewCell.View.Margin.Bottom));
            var width = (int)((view.ItemWidth + viewCell.View.Margin.Left + viewCell.View.Margin.Right));
            viewCell.View.Layout(new Rectangle(0, 0, width, height));

            if (Platform.GetRenderer(viewCell.View) == null)
            {
                Platform.SetRenderer(viewCell.View, Platform.CreateRenderer(viewCell.View));
            }
            var renderer = Platform.GetRenderer(viewCell.View).NativeView;

            foreach (UIView subView in ContentView.Subviews)
            {
                subView.RemoveFromSuperview();
            }
            renderer.ContentMode = UIViewContentMode.ScaleAspectFit;
            ContentView.AddSubview(renderer);
        }
    }
}
