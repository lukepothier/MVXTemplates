using System;
using System.Collections.Generic;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using UIKit;

namespace $rootnamespace$
{
    public class $safeitemname$ : MvxIosSetup
    {
        public $safeitemname$(MvxApplicationDelegate applicationDelegate, UIWindow window)
               : base(applicationDelegate, window)
        {
        }

        // CreateApp() is the only method for which an override is required in Setup, however there are many other methods that you will probably need or want to override
        // Learn more about using Setup to register custom bindings, platform services, and more at https://github.com/MvvmCross/MvvmCross/wiki/Customizing-using-App-and-Setup#setupcs
        protected override IMvxApplication CreateApp() => new App();

        // InitializeFirstChance is where MvvmCross initializes platform-specific services to which you would like App.Initialize to have access
        // Registering an iOS implementation of an interface in your PCL here allows for App.Initialize to reference that interface's members
        // If it's not necessary for a service to be available so early in the startup process, consider initializing it during InitializeLastChance instead
        protected override void InitializeFirstChance()
        {
            // No need to call base.InitializeFirstChance() - it's empty
        }

        // FillTargetFactories is where your applications custom bindings are registered
        // Custom bindings are a staple of MvvmCross apps, since they allow for two-way binding for platform-specific controls
        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            base.FillTargetFactories(registry);
        }

        // Use InitializeLastChance for platform-specific services that need only be available after App has been initialized
        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();
        }

        // A custom presenter is a necessity if an app employs complex navigation techniques like split-screens, tabs, and the like
        // Learn more about custom view presenters at https://slodge.blogspot.com/2013/06/presenter-roundup.html
        protected override IMvxIosViewPresenter CreatePresenter() 
            => new MyCustomPresenter(ApplicationDelegate, Window);

        // TODO :: Benchmark and decide whether this is worth including
        // If the InitializeViewLookup override does not exist, MvvmCross will use reflection to map iOS views to ViewModels
        // Reflection is very expensive, and the cost can be avoided by providing a dictionary of your mappings here
        // At scale, apps will start up measurably faster if this override exists
        protected override void InitializeViewLookup()
        {
            var viewModelViewLookup = new Dictionary<Type, Type>()
            {
                [typeof (MyViewModel)] = typeof(MyView)
            };

            var container = Mvx.Resolve<IMvxViewsContainer>();
            container.AddAll(viewModelViewLookup);
        }
    }
}
