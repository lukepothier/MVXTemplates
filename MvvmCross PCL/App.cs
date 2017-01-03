using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using $safeprojectname$.ViewModels;

namespace $safeprojectname$
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MyViewModel>();
        }
    }
}
