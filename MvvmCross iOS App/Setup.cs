using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using UIKit;
//using MyCoreProject;

namespace $safeprojectname$
{
    public class Setup : MvxIosSetup
    {
        // This is a basic MVX Setup class. It can be replaced with an advanced Setup class available in the MVX Template pack
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
                : base(applicationDelegate, window)
        {
        }

        // CreateApp() is the only method for which an override is required in Setup, however there are many other methods that you will probably need or want to override
        // Learn more about using Setup to register custom bindings, platform services, and more at https://github.com/MvvmCross/MvvmCross/wiki/Customizing-using-App-and-Setup#setupcs
        protected override IMvxApplication CreateApp() => new App();
    }
}
