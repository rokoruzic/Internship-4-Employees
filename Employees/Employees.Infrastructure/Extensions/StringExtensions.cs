using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employees.Infrastructure.Extensions
{
	public static class StringExtensions
	{
		public static string CapitalizeFirstLetterAndRemoveMultipleWhiteSpaces(this string text)
		{
			if (text.Length == 0)
				return text;
			text = text.Trim();
			var regex = new Regex(@"\s{2,}");
			while (regex.IsMatch(text))
				text = regex.Replace(text, " ", 1);
			text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
			return text;
		}

		public static string RemoveAllWhiteSpaces(this string text)
		{
			text = text.Trim();
			text = text.Replace(" ", "");
			return text;
		}
		public static string FirstCharToUpperAndRemoveMultipleWhiteSpaces(this string text)
		{
			if (text.Length == 0)
				return text;
			text = text.Trim();
			var regex = new Regex(@"\s{2,}");
			while (regex.IsMatch(text))
				text = regex.Replace(text, " ", 1);
			text = CultureInfo.CurrentCulture.TextInfo.ToUpper(text);
			return text;
		}
	}
}
