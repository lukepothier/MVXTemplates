using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
//using MyPCL;

namespace $safeprojectname$
{
    [MvxFragment(typeof(MyContainerViewModel), Resource.Id.content_frame)]
    [Register(nameof(MyFragment))]
    public class MyFragment : MvxFragment<MyViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            // If your bindings for this fragment are done in XML, you need to call this.BindingInflate. If not, call inflater.Inflate instead
            // The two are mutually exclusive -- use only the one you need
            var view = this.BindingInflate(Resource.Layout.layout_fragment, null);
            //var view = inflater.Inflate(Resource.Layout.layout_fragment, null);

            return view;
        }
    }
}
