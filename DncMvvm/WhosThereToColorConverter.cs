using System;
using System.Globalization;
using Xamarin.Forms;

namespace DncMvvm
{
	public class WhosThereToColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var stringValue = value as string;

			if (string.IsNullOrWhiteSpace(stringValue))
				return Color.Black;

			if (stringValue.ToLowerInvariant().Contains("who"))
				return Color.Red;

			return Color.Black;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
