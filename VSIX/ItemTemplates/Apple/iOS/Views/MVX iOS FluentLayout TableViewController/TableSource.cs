using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace $rootnamespace$
{
    public class $safeitemname$TableSource : MvxTableViewSource
    {
        public $safeitemname$TableSource(UITableView tableView)
            : base(tableView)
        {
            tableView.RegisterClassForCellReuse(typeof($safeitemname$TableCell), $safeitemname$TableCell.Identifier);
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
            => tableView.DequeueReusableCell($safeitemname$TableCell.Identifier, indexPath);
    }
}
