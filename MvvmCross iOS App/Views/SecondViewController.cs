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
        
            View.AddSubviews();

            View.AddConstraints(new FluentLayout[]
            {
                
            });

            var bindingSet = this.CreateBindingSet<SecondViewController, SecondViewModel>();
        
            bindingSet.Apply();
        }
    }
}
