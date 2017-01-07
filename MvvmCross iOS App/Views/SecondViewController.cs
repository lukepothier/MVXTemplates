using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
//using MyCoreProject.ViewModels;

namespace $safeprojectname$.Views
{
    public class SecondViewController : BaseViewController<SecondViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var goBackButton = new UIButton();

            goBackButton.SetTitle("Go Back");
        
            View.AddSubviews(goBackButton);

            View.AddConstraints(new FluentLayout[]
            {
                goBackButton.AtTopOf(View),
                goBackButton.WithSameCenterX(View)
            });

            var bindingSet = this.CreateBindingSet<SecondViewController, SecondViewModel>();

            bindingSet.Bind(goBackButton).To(vm => vm.GoBackCommand);
        
            bindingSet.Apply();
        }
    }
}
