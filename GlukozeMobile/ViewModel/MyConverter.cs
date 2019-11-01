using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Xamarin.Forms;


namespace GlukozeMobile.ViewModel
{
    class MyConverter : IValueConverter
    {
        protected string dot = ".";
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value.ToString().Contains(dot)) return value.ToString().Replace(".", ",");
            else if (value != null) return value.ToString();
            else return null;
        }
    }

}
