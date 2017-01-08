using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Binding.BindingContext;
using UIKit;
//using MyCoreProject.ViewModels;

namespace $safeprojectname$.Views
{
    [Register(nameof(SecondViewController))]
    public class SecondViewController : BaseViewController<SecondViewModel>
    {
        UIButton _goBackButton;
        MvxFluentBindingDescriptionSet<SecondViewController, SecondViewModel> _bindingSet;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "Second View";

            CreateViewElements();

            LayoutViewElements();

            Bind();
        }

        void CreateViewElements()
        {
            _goBackButton = new UIButton(UIButtonType.RoundedRect);
            _goBackButton.SetTitle("Go Back", UIControlState.Normal);
            Add(_goBackButton);
        }

        void Bind()
        {
            _bindingSet = this.CreateBindingSet<SecondViewController, SecondViewModel>();

            _bindingSet.Bind(_goBackButton).To(vm => vm.GoBackCommand);

            _bindingSet.Apply();
        }

        void LayoutViewElements()
        {
            //var constraints = View.VerticalStackPanelConstraints(
            //                                new Margins(20, 10, 20, 10, 5, 5),
            //                                View.Subviews);
            //View.AddConstraints(constraints);

            View.AddConstraints(new FluentLayout[]
            {
                _goBackButton.AtTopOf(View, 12f),
                _goBackButton.WithSameCenterX(View)
            });
        }
    }
}
