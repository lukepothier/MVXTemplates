using System;
using System.Globalization;
using MvvmCross.Platform.UI;
using MvvmCross.Plugins.Visibility;

namespace $rootnamespace$
{
    // Requires MvvmCross Visibility Plugin install:
    // https://www.nuget.org/packages/MvvmCross.Plugin.Visibility/
    // For more information on how to use Value Converter see:
    // https://mvvmcross.com/docs/value-converters
    public class $safeitemname$ : MvxBaseVisibilityValueConverter<ViewModelPropertyType>
    {
        // Used for changing ViewModel values into View visibility state
        protected override MvxVisibility Convert(ViewModelPropertyType value, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
