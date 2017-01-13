using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using UIKit;
using $saferootprojectname$.Core.ViewModels;

namespace $safeprojectname$.Views
{
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

        void LayoutViewElements()
        {
            View.AddConstraints(new FluentLayout[]
            {
                _goForwardButton.AtTopOf(View, 12f),
                _goForwardButton.WithSameCenterX(View)
            });
        }

        void Bind()
        {
            _bindingSet = this.CreateBindingSet<FirstViewController, FirstViewModel>();

            _bindingSet.Bind(_goForwardButton).To(vm => vm.GoForwardCommand);

            _bindingSet.Apply();
        }
    }
}