using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace launcher_master.Converters
{
    public class ArcEndPointConverter : IMultiValueConverter
    {
        public const string ParameterMidPoint = "MidPoint";

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double actualWidth = values[0].ExtractDouble();
            double value = values[1].ExtractDouble();
            double minimum = values[2].ExtractDouble();
            double maximum = values[3].ExtractDouble();

            if (new[] { actualWidth, value, minimum, maximum }.AnyNan())
                return Binding.DoNothing;

            if (values.Length == 5)
            {
                double fullIndeterminateScaling = values[4].ExtractDouble();
                if (!double.IsNaN(fullIndeterminateScaling) && fullIndeterminateScaling > 0.0)
                {
                    value = (maximum - minimum) * fullIndeterminateScaling;
                }
            }

            double percent = maximum <= minimum ? 1.0 : (value - minimum) / (maximum - minimum);
            if (Equals(parameter, ParameterMidPoint))
                percent /= 2;

            double degrees = 360 * percent;
            double radians = degrees * (Math.PI / 180);

            var centre = new Point(actualWidth / 2, actualWidth / 2);
            double hypotenuseRadius = (actualWidth / 2);

            double adjacent = Math.Cos(radians) * hypotenuseRadius;
            double opposite = Math.Sin(radians) * hypotenuseRadius;

            return new Point(centre.X + opposite, centre.Y - adjacent);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}