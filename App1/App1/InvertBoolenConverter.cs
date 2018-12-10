using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1
{
    public class InvertBoolenConverter : IValueConverter
    {

        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            String s = (String)value;
            if (s.Length > 300)
            {
                s = s.Substring(0, 300);
            }
            return s + "..";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
