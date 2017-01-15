using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace $rootnamespace$
{
    public class $safeitemname$ : MvxCollectionViewController<MyViewModel>
    {
        MvxFluentBindingDescriptionSet<$safeitemname$, MyViewModel> _bindingSet;
        $safeitemname$CollectionSource _source;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _source = new $safeitemname$CollectionSource(CollectionView);

            CreateViewElements();

            LayoutViewElements();

            Bind();
        }

        void CreateViewElements()
        {
            // Create your controls, and assign them to class-level variables the way that _bindingSet is assigned below.
            // This pattern allows you to split up the process of creating and binding a UI into small, modular methods

            // Calling this method allows FluentLayout to manage the layout of your UI
            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            // Don't forget to add your controls to the View
            View.AddSubviews(/* your views here */);
        }

        void LayoutViewElements()
        {
            View.AddConstraints(new FluentLayout[]
            {
                // For FluentLayout samples and how-tos, see https://github.com/FluentLayout/Cirrious.FluentLayout#fluentlayout
            });
        }

        void Bind()
        {
            _bindingSet = this.CreateBindingSet <$safeitemname$, MyViewModel>();

            // Bind your UI elements to ViewModel members using _bindingSet.Bind
            _bindingSet.Bind(_source).For(s => s.ItemsSource).To(vm => vm.MyObservableCollection);

            _bindingSet.Apply();
        }
    }
}
