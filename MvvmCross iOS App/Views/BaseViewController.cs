using Cirrious.FluentLayouts.Touch;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;

namespace $safeprojectname$.Views
{
    public abstract class BaseViewController<TViewModel> : MvxViewController<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // This can be removed if you're not using FluentLayout
            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
        }
    }
}
