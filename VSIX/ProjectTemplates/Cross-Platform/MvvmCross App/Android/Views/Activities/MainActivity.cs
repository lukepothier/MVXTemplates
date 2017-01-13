using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Platform;
using $saferootprojectname$.Core.ViewModels;

namespace $safeprojectname$.Views
{
    [Activity(
        Theme = "@style/$safeprojectname$", 
        WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden)]
    public class MainActivity : BaseActivity<MainContainerViewModel>
    {
        protected override int ActivityLayoutId => Resource.Layout.layout_activity;
    }
}
