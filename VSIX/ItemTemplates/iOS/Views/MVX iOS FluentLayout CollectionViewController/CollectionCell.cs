using System;
using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;

namespace $rootnamespace$
{
    public class $safeitemname$CollectionCell : MvxCollectionViewCell
    {
        public static readonly NSString Identifier = new NSString(nameof($safeitemname$CollectionCell));
        MvxFluentBindingDescriptionSet<$safeitemname$CollectionCell, MyItemViewModel> _bindingSet;

        public $safeitemname$CollectionCell(IntPtr handle)
            : base(handle)
        {
            CreateViewElements();

            LayoutViewElements();

            Bind();
        }

        void CreateViewElements()
        {
            this.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            AddSubviews(/* your views here */);
        }

        void LayoutViewElements()
        {
            this.AddConstraints(new FluentLayout[]
            {

            });
        }

        void Bind()
        {
            this.DelayBind(() =>
            {
                _bindingSet = this.CreateBindingSet<$safeitemname$CollectionCell, MyItemViewModel >();

                _bindingSet.Apply();
            });
        }
    }
}
