using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using UIKit;
//using MyCoreProject.ViewModels;

namespace $safeprojectname$.Views
{
    public class FirstViewController : BaseViewController<FirstViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "First View";

            var goForwardButton = new UIButton();

            goForwardButton.SetTitle("Go Forward", UIControlState.Normal);
        
            View.AddSubviews(goForwardButton);

            View.AddConstraints(new FluentLayout[]
            {
                goForwardButton.AtTopOf(View),
                goForwardButton.WithSameCenterX(View)
            });

            var bindingSet = this.CreateBindingSet<FirstViewController, FirstViewModel>();

            bindingSet.Bind(goForwardButton).To(vm => vm.GoForwardCommand);
        
            bindingSet.Apply();
        }
    }
}
