﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PROG6212.Converters
{

    // https://www.melodiouscode.net/passing-multiple-parameters-to-an-icommand-in-wpf
    public class ArrayMultiValueConverter : IMultiValueConverter
    {
        #region interface implementations

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.Clone();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
