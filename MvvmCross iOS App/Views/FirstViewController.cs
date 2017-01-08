using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Binding.BindingContext;
using UIKit;
//using MyCoreProject.ViewModels;

namespace $safeprojectname$.Views
{
    [Register(nameof(FirstViewController))]
    public class FirstViewController : BaseViewController<FirstViewModel>
    {
        UIButton _goForwardButton;
        MvxFluentBindingDescriptionSet<FirstViewController, FirstViewModel> _bindingSet;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "First View";

            CreateViewElements();

            LayoutViewElements();

            Bind();
        }

        void CreateViewElements()
        {
            _goForwardButton = new UIButton(UIButtonType.RoundedRect);
            _goForwardButton.SetTitle("Go Forward", UIControlState.Normal);
            Add(_goForwardButton);
        }

        void Bind()
        {
            _bindingSet = this.CreateBindingSet<FirstViewController, FirstViewModel>();

            _bindingSet.Bind(_goForwardButton).To(vm => vm.GoForwardCommand);

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
                _goForwardButton.AtTopOf(View, 12f),
                _goForwardButton.WithSameCenterX(View)
            });
        }
    }
}