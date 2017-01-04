using Android.OS;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V4;

namespace $safeprojectname$.Views
{
    public abstract class BaseFragment<TViewModel> : MvxFragment<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        protected abstract int FragmentId { get; }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            // If your bindings for this fragment are done in XML, you need to call this.BindingInflate. If not, call inflater.Inflate instead
            // The two are mutually exclusive -- use only the one you need
            var view = this.BindingInflate(FragmentId, null);
            //var view = inflater.Inflate(FragmentId, null);

            return view;
        }
    }
}