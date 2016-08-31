using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TreeListViewApp
{
    public class LevelToIndentConverter : IValueConverter
    {
        private static readonly LevelToIndentConverter DefaultInstance = new LevelToIndentConverter();

        public static LevelToIndentConverter Default
        {
            get { return DefaultInstance; }
        }

        private const double IndentSize = 20.0;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new Thickness((int)value * IndentSize, 0, 0, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
