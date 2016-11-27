using Android.Content;
using MvvmCross.Core.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Views;

namespace $rootnamespace$
{
    public class Setup : MvxAndroidAppCompatSetup
    {
        public Setup(Context applicationContext)
               : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp() => new App();

        // InitializeFirstChance is where MvvmCross initializes platform-specific services to which you would like App.Initialize to have access
        // Registering an Android implementation of an interface in your PCL here allows for App.Initialize to reference that interface's members
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

        // For apps that make use of custom Android views, you need to provide the assemblies in which MvvmCross should look to find the views
        // This is particularly useful for apps which make use of the Android support libraries
        // Below are some commonly used assemblies - remove the ones your app doesn't require
        protected override IEnumerable<Assembly> AndroidViewAssemblies => 
            new List<Assembly>(base.AndroidViewAssemblies)
                {
                    typeof(Android.Support.Design.Widget.FloatingActionButton).Assembly,
                    typeof(MvvmCross.Droid.Support.V7.RecyclerView.MvxRecyclerView).Assembly
                };

        // Using Android fragments requires the use of MvxFragmentsPresenter
        // A custom presenter is a necessity if an app employs complex navigation techniques like split-screens, tabs, and the like
        // Learn more about custom view presenters at https://slodge.blogspot.com/2013/06/presenter-roundup.html
        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var mvxPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);
            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxPresenter);
            return mvxPresenter;
        }

    // TODO :: Benchmark and decide whether this is worth including
    // If the InitializeViewLookup override does not exist, MvvmCross will use reflection to map Android views to ViewModels
    // Reflection is very expensive, and the cost can be avoided by providing a dictionary of your mappings here
    // At scale, apps will start up measurably faster if this override exists
    protected override void InitializeViewLookup()
        {
            var viewModelViewLookup = new Dictionary<Type, Type>()
                        {
                            { typeof (MyViewModel), typeof(MyView) }
                        };

            var container = Mvx.Resolve<IMvxViewsContainer>();
            container.AddAll(viewModelViewLookup);
        }
    }
}
