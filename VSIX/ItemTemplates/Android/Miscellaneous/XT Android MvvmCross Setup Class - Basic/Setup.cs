using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Shared.Presenter;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;

namespace $rootnamespace$
{
    public class Setup : MvxAppCompatSetup
{
        public Setup(Context applicationContext)
               : base(applicationContext)
        {
        }

        // CreateApp() is the only method for which an override is required in Setup, however there are many other methods that you will probably need or want to override
        // Learn more about using Setup to register custom bindings, platform services, and more at https://github.com/MvvmCross/MvvmCross/wiki/Customizing-using-App-and-Setup#setupcs
        protected override IMvxApplication CreateApp() => new App();

        // Using Android fragments requires the use of MvxFragmentsPresenter
        // If the use of fragments are not required you can remove this override, which will default to the use of MvxAndroidViewPresenter
        // Learn more about custom view presenters at https://slodge.blogspot.com/2013/06/presenter-roundup.html
        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var mvxPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);
            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxPresenter);
            return mvxPresenter;
        }
}
}
