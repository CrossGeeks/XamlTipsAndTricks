using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace XamlTipsAndTricks.Converter
{
	public class ListHeightConverter : IValueConverter
	{
		public object Convert(object value, Type targetType,
							  object parameter, CultureInfo culture)
		{
			if (value == null)
				return 0;

            return ((IList)value).Count * Int32.Parse(parameter.ToString());
		}

		public object ConvertBack(object value, Type targetType,
								  object parameter, CultureInfo culture)
		{
			if (value == null)
				return 0;

			return ((IList)value).Count * Int32.Parse(parameter.ToString());
		}
	}
}