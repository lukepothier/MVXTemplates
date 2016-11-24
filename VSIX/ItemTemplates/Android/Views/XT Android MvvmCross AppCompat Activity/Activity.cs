using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Mvx.Droid.Support.V7.AppCompat;

namespace $rootnamespace$
{
    [Activity(Theme = "@style/MyAppTheme",
            WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden)]
public class Activity : MvxAppCompatActivity<MyViewModel>
{

    #region Activity LifeCycle

    protected override void OnCreate(Bundle bundle)
    {
        // The following two lines can be removed if this activity is navigated to immediately after the splash screen
        var setupSingleton = MvxAndroidSetupSingleton.EnsureSingletonAvailable(ApplicationContext);
        setupSingleton.EnsureInitialized();

        base.OnCreate(bundle);

        SetContentView(Resource.Layout.my_resource_name);
    }

    #endregion
}
}
