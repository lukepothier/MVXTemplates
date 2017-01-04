using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
//using MyCoreProject.ViewModels;

namespace $safeprojectname$.Views
{
    [MvxFragment(typeof(MyContainerViewModel), Resource.Id.content_frame)]
    [Register(nameof(SecondFragment))]
    public class SecondFragment : BaseFragment<SecondViewModel>
    {
        protected override int FragmentId => Resource.Layout.layout_fragment_second;
    }
}