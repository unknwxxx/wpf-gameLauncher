using System;
using System.Globalization;
using System.Windows.Data;

namespace launcher_master.Converters
{
    public class RotateTransformCentreConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) 
            => (double)value / 2;
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) 
            => Binding.DoNothing;
       
    }
}