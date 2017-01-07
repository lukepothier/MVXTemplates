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

            var goForwardButton = new UIButton();

            goForwardButton.SetTitle("Go Forward");
        
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
