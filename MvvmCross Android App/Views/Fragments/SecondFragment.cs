using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
//using MyCoreProject.ViewModels;

namespace $safeprojectname$.Views
{
    [MvxFragment(typeof(MainContainerViewModel), Resource.Id.content_frame, true)]
    [Register(nameof(SecondFragment))]
    public class SecondFragment : BaseFragment<SecondViewModel>
    {
        protected override int FragmentId => Resource.Layout.layout_fragment_second;
        Button _goBackButton;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            _goBackButton = view.FindViewById<Button>(Resource.Id.button);

            Bind();

            return view;
        }

        void Bind()
        {
            var bindingSet = this.CreateBindingSet<SecondFragment, SecondViewModel>();

            bindingSet.Bind(_goBackButton).To(vm => vm.GoBackCommand);

            bindingSet.Apply();
        }
    }
}