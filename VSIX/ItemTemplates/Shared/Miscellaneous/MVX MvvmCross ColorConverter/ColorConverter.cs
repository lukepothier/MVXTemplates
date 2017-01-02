using System;
using System.Globalization;
using MvvmCross.Platform.UI;
using MvvmCross.Plugins.Color;

namespace $rootnamespace$
{
    // Requires MvvmCross Color Plugin install:
    // https://www.nuget.org/packages/MvvmCross.Plugin.Color/
    // For more information on how to use Value Converter see:
    // https://mvvmcross.com/docs/value-converters
    public class $safeitemname$ : MvxColorValueConverter<ViewModelPropertyType>
    {
        // Used for changing ViewModel values into View colors
        protected override MvxColor Convert(ViewModelPropertyType value, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
