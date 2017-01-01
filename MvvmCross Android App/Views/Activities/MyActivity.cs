using Android;
using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Views;
using MvvmCross.Droid.Platform;
//using MyPCL

namespace $safeprojectname$
{
    [Activity(Theme = "@style/$safeprojectname$", 
        WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden, 
        Label = nameof(MyActivity), 
        MainLauncher = true)]
    public class MyActivity : MvxAppCompatActivity<MyViewModel>
    {
        #region Activity LifeCycle

        protected override void OnCreate(Bundle bundle)
        {
            // The following two lines can be removed if this activity is navigated to immediately after the splash screen
            var setupSingleton = MvxAndroidSetupSingleton.EnsureSingletonAvailable(ApplicationContext);
            setupSingleton.EnsureInitialized();

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.layout_first);
        }

        #endregion
    }
}
