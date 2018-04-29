using System;
using Core.Controls;
using Core.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(WhatsAppViewCell), typeof(WhatsAppViewCellRenderer))]
namespace Core.iOS.Renderers
{
    public class WhatsAppViewCellRenderer : ViewCellRenderer
    {
		public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
		{
            tv.SeparatorInset = new UIEdgeInsets(0, 90, 0, 0);
            return base.GetCell(item, reusableCell, tv);
		}
	}
}
