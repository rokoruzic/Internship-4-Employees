using System.Globalization;
using System.Text.RegularExpressions;

namespace Employees.Infrastructure.Extensions
{
	public static class StringExtensions
	{
		public static string CapitalizeFirstLetterAndRemoveMultipleWhiteSpaces(this string text)
		{
			text = PrepareTextForUpperCasing(text);
			text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
			return text;
		}

		private static string PrepareTextForUpperCasing(string text)
		{
			if (string.IsNullOrEmpty(text))
				return text;
			text = text.Trim();
			var regex = new Regex(@"\s{2,}");
			while (regex.IsMatch(text))
				text = regex.Replace(text, " ", 1);
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
			text = PrepareTextForUpperCasing(text);
			text = char.ToUpper(text[0]) + text.Substring(1);
			return text;
		}
	}
}
