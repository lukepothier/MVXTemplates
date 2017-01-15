using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace $rootnamespace$
{
    public class $safeitemname$CollectionSource : MvxCollectionViewSource
    {
        public $safeitemname$CollectionSource(UICollectionView collectionView)
            : base(collectionView)
        {
            collectionView.RegisterClassForCellReuse(typeof($safeitemname$CollectionCell), $safeitemname$CollectionCell.Identifier);
        }

        protected override UICollectionViewCell GetOrCreateCellFor(UICollectionView collectionView, NSIndexPath indexPath, object item)
            => collectionView.DequeueReusableCell($safeitemname$CollectionCell.Identifier, indexPath);
    }
}
