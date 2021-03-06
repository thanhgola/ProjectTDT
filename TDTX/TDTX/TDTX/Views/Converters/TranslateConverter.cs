﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TDTX.Common;
using Xamarin.Forms;

namespace TDTX.Views.Converters
{
    public class TranslateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return TextProvider.Translate(value as string);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
