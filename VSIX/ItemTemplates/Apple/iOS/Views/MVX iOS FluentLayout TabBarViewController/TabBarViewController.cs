// Basically copied from Stuart Lodge's sample:
// https://github.com/MvvmCross/MvvmCross-Tutorials/blob/master/Sample%20-%20CirriousConference/Cirrious.Conference.UI.Touch/Views/TabBarController.cs

using MvvmCross.iOS.Views;
using UIKit;

namespace $rootnamespace$
{
    public class $safeitemname$ : MvxTabBarViewController<MyViewModel>, ITabBarPresenter
    {
        int _tabCount;

        public $safeitemname$()
        {
            Mvx.Resolve<ITabBarPresenterHost>().TabBarPresenter = this;

			// Because the UIKit base class calls ViewDidLoad, we have to make a second call here
			ViewDidLoad();
		}

        public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		
			// ViewModel will only not be null during execution of the manual call in the constructor
			if (ViewModel == null)
				return;

		    var viewControllers = new UIViewController[]
            {
                CreateTab("Tab 1", "tab_1.png", FirstViewModel),
                CreateTab("Tab 2", "tab_2.png", SecondViewModel)
            };

            ViewControllers = viewControllers;
            CustomizableViewControllers = new UIViewController[] { };
            SelectedViewController = ViewControllers[0];
        }

        UIViewController CreateTab(string title, string imagePath, IMvxViewModel viewModel)
        {
            var controller = new UINavigationController();
            var view = this.CreateViewControllerFor(viewModel) as UIViewController;
            SetTitleAndTabBarItem(view, title, imagePath);
            controller.PushViewController(view, false);
            return controller;
        }

        void SetTitleAndTabBarItem(UIViewController view, string title, string imagePath)
        {
            view.Title = ViewModel.TextSource.GetText(title);
            view.TabBarItem = new UITabBarItem(title, UIImage.FromBundle($"Path/To/Images/{imagePath}"), _tabCount);
            _tabCount++;
        }
    }
}
