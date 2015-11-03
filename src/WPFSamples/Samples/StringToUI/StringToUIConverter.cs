using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPFSamples.Samples.StringToUI
{
    public class StringToUIConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || (!(value is string)))
                return null;

            var header = "<Grid xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' " +
                         "xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>";

            var footer = "</Grid>";

            var xaml = header + (string)value + footer;

            var UI = System.Windows.Markup.XamlReader.Parse(xaml) as UIElement;
            return UI;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}