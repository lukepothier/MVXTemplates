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

            CreateViewElements();

            LayoutViewElements();

            Bind();
        }

        void CreateViewElements()
        {
            // Create your controls, and assign them to class-level variables the way that _bindingSet is assigned below.
            // This pattern allows you to split up the process of creating and binding a UI into small, modular methods

            // Calling this method allows FluentLayout to manage the layout of your UI
            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            // Don't forget to add your controls to the View
            View.AddSubviews(/* your views here */);
        }

        void LayoutViewElements()
        {
            View.AddConstraints(new FluentLayout[]
            {
                // For FluentLayout samples and how-tos, see https://github.com/FluentLayout/Cirrious.FluentLayout#fluentlayout
            });
        }

        void Bind()
        {
            _bindingSet = this.CreateBindingSet<$safeitemname$, MyViewModel>();

            // Bind your UI elements to ViewModel members using _bindingSet.Bind

            _bindingSet.Apply();
        }
    }
}
