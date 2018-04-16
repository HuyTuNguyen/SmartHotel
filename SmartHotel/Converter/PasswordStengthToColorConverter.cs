using System;
using System.Globalization;
using Xamarin.Forms;

namespace SmartHotel.Converter
{
    public class PasswordStrengthToColorConverter:IValueConverter
    {
        public PasswordStrengthToColorConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value.ToString() == "Good")
                return Color.LawnGreen;
            return Color.OrangeRed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
