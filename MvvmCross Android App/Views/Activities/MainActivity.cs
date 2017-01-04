using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Platform;
//using MyCoreProject.ViewModels;

namespace $safeprojectname$.Views
{
    [Activity(
        Theme = "@style/$safeprojectname$", 
        WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden)]
    public class MainActivity : BaseActivity<MainContainerViewModel>
    {
        #region Activity LifeCycle

        protected override void OnCreate(Bundle bundle)
        {
            // The following two lines can be removed if this activity is navigated to immediately after the splash screen
            var setupSingleton = MvxAndroidSetupSingleton.EnsureSingletonAvailable(ApplicationContext);
            setupSingleton.EnsureInitialized();

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.layout_activity);
        }

        #endregion
    }
}
