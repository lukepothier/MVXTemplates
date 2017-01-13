using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using UIKit;
using $saferootprojectname$.Core.ViewModels;

namespace $safeprojectname$.Views
{
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

        void LayoutViewElements()
        {
            View.AddConstraints(new FluentLayout[]
            {
                _goBackButton.AtTopOf(View, 12f),
                _goBackButton.WithSameCenterX(View)
            });
        }

        void Bind()
        {
            _bindingSet = this.CreateBindingSet<SecondViewController, SecondViewModel>();

            _bindingSet.Bind(_goBackButton).To(vm => vm.GoBackCommand);

            _bindingSet.Apply();
        }
    }
}
