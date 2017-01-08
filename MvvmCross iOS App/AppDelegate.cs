using System.Net;
using Foundation;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.Platform;
using UIKit;

namespace $safeprojectname$
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate
    {
        UIWindow _window;

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            _window = new UIWindow(UIScreen.MainScreen.Bounds);

            // HACK :: Prevents DNS caching to avoid NameResolutionFailures from persisting when connectivity is restored if app is started while not online
            // Workaround for a Mono bug: https://bugzilla.xamarin.com/show_bug.cgi?id=45761
            ServicePointManager.DnsRefreshTimeout = 0;

            var setup = new Setup(this, _window);
            setup.Initialize();

            var startup = Mvx.Resolve<IMvxAppStart>();
            startup.Start();

            _window.MakeKeyAndVisible();

            return true;
        }
    }
}
