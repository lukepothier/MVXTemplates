using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;

namespace $rootnamespace$
{
    [Activity(Label = "",
            Theme = "@style/MyAppTheme",
            LaunchMode = LaunchMode.SingleTask,
            ScreenOrientation = ScreenOrientation.User,
            WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden)]
    public class Activity : AppCompatActivity
    {
    
        #region Activity LifeCycle

        protected override void OnCreate(Bundle bundle)
        {
            var setupSingleton = MvxAndroidSetupSingleton.EnsureSingletonAvailable(ApplicationContext);
            setupSingleton.EnsureInitialized();

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_dashboard_main);
        }

        #endregion
    }
}
