using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace $rootnamespace$
{
    // For more information on how to use Value Converter see:
    // https://mvvmcross.com/docs/value-converters
    public class $safeitemname$ : MvxValueConverter<ViewModelPropertyType, ViewPropertyType>
    {
        // Used for changing ViewModel values into View values
        protected override ViewPropertyType Convert(ViewModelPropertyType value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    
        // Used for changing View values into ViewModel values
        // Can be removed if only one-way binding (ViewModel -> View) is being used
        protected override ViewModelPropertyType ConvertBack(ViewPropertyType value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}