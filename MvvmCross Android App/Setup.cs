using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Shared.Presenter;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;
//using MyCoreProject;

namespace $safeprojectname$
{
    public class Setup : MvxAppCompatSetup
    {
        // This is a basic MVX Setup class. It can be replaced with an advanced Setup class available in the MVX Template pack
        public Setup(Context applicationContext)
               : base(applicationContext)
        {
        }

        // CreateApp() is the only method for which an override is required in Setup, however there are many other methods that you will probably need or want to override
        // Learn more about using Setup to register custom bindings, platform services, and more at https://github.com/MvvmCross/MvvmCross/wiki/Customizing-using-App-and-Setup#setupcs
        protected override IMvxApplication CreateApp() => new App();
    }
}
