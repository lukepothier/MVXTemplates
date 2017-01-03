using MvvmCross.Core.ViewModels;

namespace $safeprojectname$.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {

        #region Commands

        IMvxCommand _goForwardCommand;
            public IMvxCommand GoForwardCommand =>
                _goForwardCommand ?? (_goForwardCommand = new MvxCommand(() => { GoForward(); }));

        #endregion

        #region Helpers

        void GoForward()
        {
            ShowViewModel<SecondViewModel>();
        }

        #endregion

    }
}
