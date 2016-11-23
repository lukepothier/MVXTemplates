using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;

namespace $rootnamespace$
{
    [MvxFragment(typeof(MyViewModel), Resource.Id.my_resource_id)]
    [Register("sanlamactive.android.fragments.goCoverFragment")]
    public class Fragment : MvxFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            return view;
        }
    }
}
