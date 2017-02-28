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
    [Register(nameof(FirstFragment))]
    public class FirstFragment : BaseFragment<FirstViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.layout_fragment_first;
        Button _goForwardButton;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            _goForwardButton = view.FindViewById<Button>(Resource.Id.button);

            Bind();

            return view;
        }

        void Bind()
        {
            var bindingSet = this.CreateBindingSet<FirstFragment, FirstViewModel>();

            bindingSet.Bind(_goForwardButton).To(vm => vm.GoForwardCommand);

            bindingSet.Apply();
        }
    }
}
