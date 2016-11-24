using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Platform;

namespace $rootnamespace$
{
    public class Setup : MvxAndroidAppCompatSetup
{
    public Setup(Context applicationContext)
           : base(applicationContext)
    {
    }

    // CreateApp() is the only method for which an override is required in Setup, however there are many other methods that you will probably need or want to override within Setup
    // Learn more about using Setup to register custom bindings, improve startup performace, and more at https://github.com/MvvmCross/MvvmCross/wiki/Customizing-using-App-and-Setup#setupcs
    protected override IMvxApplication CreateApp() => new App();

    // Using Android support libraries (which is usually a good idea) requires the use of a non-standard presenter
    // Learn more about custom view presenters at https://slodge.blogspot.com/2013/06/presenter-roundup.html
    protected override IMvxAndroidViewPresenter CreateViewPresenter()
    {
        var customPresenter = new MvxFragmentPresenter(AndroidViewAssemblies);
        return customPresenter;
    }
}
}
