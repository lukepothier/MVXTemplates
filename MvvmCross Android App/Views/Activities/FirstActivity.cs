using Android.App;
using Android.Widget;
using Android.OS;

namespace $safeprojectname$
{
    [Activity(Label = "FirstActivity", MainLauncher = true)]
    public class FirstActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.layout_first);
        }
    }
}

