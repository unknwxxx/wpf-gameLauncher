using System;
using System.Globalization;
using System.Windows.Data;

namespace launcher_master.Converters
{
    class PositiveToNegativeConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => (double)value > 0 ? 0 - (double)value : 0;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
