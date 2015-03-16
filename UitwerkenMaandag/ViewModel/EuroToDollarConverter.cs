using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace UitwerkenMaandag.ViewModel
{
    //Ik hang aan een binding, meer weet ik niet
    public class EuroToDollarConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double price = (double)value;
            return price * 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string price = (string)value;

            return double.Parse(price) / 2;
        }
    }
}
