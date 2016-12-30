using Foundation;
using UIKit;

namespace $safeprojectname$
{
    [Register(nameof(AppDelegate))]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow Window
    {
        get;
        set;
    }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        Window = new UIWindow(UIScreen.MainScreen.Bounds);

        Window.MakeKeyAndVisible();

        return true;
    }
}
}
