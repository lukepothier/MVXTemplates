using System;
using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;

namespace $rootnamespace$
{
    public class $safeitemname$TableCell : MvxTableViewCell
    {
        public static readonly NSString Identifier = new NSString(nameof($safeitemname$TableCell));
        MvxFluentBindingDescriptionSet<$safeitemname$TableCell, MyItemViewModel> _bindingSet;

        public $safeitemname$TableCell(IntPtr handle)
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
                _bindingSet = this.CreateBindingSet<$safeitemname$TableCell, MyItemViewModel>();

                _bindingSet.Apply();
            });
        }
    }
}
