using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace $rootnamespace$
{
    public class $safeitemname$ : MvxViewController<MyViewModel>
    {
        MvxFluentBindingDescriptionSet<$safeitemname$, MyViewModel> _bindingSet;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "$safeitemname$";

            View.AddSubviews(/* your views here */);

            View.AddConstraints(new FluentLayout[]
            {
                // For FluentLayout samples and how-tos, see https://github.com/FluentLayout/Cirrious.FluentLayout#fluentlayout
            });

            _bindingSet = this.CreateBindingSet<$safeitemname$, MyViewModel>();

            // Bind your UI elements to ViewModel members using _bindingSet.Bind

            _bindingSet.Apply();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
        }
    }
}
