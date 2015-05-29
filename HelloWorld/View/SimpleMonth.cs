using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using HelloWorld.model;
using System.Windows.Data;

namespace HelloWorld.View
{
    public class SimpleMonth : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DateTime date = (DateTime)value;
            return date.ToString("MMM").ToUpper();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class SimpleDayMonth : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DateTime date = (DateTime)value;

            return date.Day + " " + date.ToString("MMM").ToUpper();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class TitleTruncate : IValueConverter
    {
        private static int maxLength = 16;
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            String title = (String)value;
            return title.Substring(0, Math.Min(title.Length, maxLength));
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class DeadLine : IValueConverter
    {
        
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DateTime date = (DateTime)value;
            SimpleDayMonth simpleDayMonth = new SimpleDayMonth();
            return "Vencimento " + simpleDayMonth.Convert(value, targetType, parameter, culture);
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class DoubleToMoney : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double v = (double) value;
            return "R$ " + v;

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class PaidAnalyzer : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double Paid = (double)value;
            if (Paid > 0) 
            {
                return "R$ 0.00";
            }

            return "R$ " + Paid * -1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class DoubleToVis : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double Total_cumulative = (double)value;
            if (Total_cumulative > 0)
            {
                return Visibility.Visible;
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    
}
