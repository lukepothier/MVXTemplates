using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

// Declarations for Android hardware and software features used by your application go here, for example
//[assembly: UsesFeature("android.hardware.camera", Required = false)]

// Declarations for Android permissions used by your application go here, for example
//[assembly: Permission(Name = Android.Manifest.Permission.Internet)]

namespace $safeprojectname$
{
    [Activity(
        MainLauncher = true,
        Theme = "@style/SplashTheme",
        Label = "Splash",
        NoHistory = true)]
    public class SplashScreenActivity : MvxSplashScreenActivity
    {
    }
}