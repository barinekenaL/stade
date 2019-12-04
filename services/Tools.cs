using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace stade.services {

	internal class Tools {

		public static DateTime GetDate(string dateStr) {
			try {
				/// get date part
				string pattern = @"^\d{1,2}[ .,/:;-]\d{1,2}[ .,/:;-]\d{4}"; /// Fr date format
				Regex regex = new Regex(pattern);
				Match match = regex.Match(dateStr);
				string datePart = "";
				if (match.Success) {
					datePart = match.Groups[0].Value;
				} else {
					pattern = @"^\d{4}[ .,/:;-]\d{1,2}[ .,/:;-]\d{1,2}"; /// En date format
					regex = new Regex(pattern);
					match = regex.Match(dateStr);
					if (match.Success) {
						datePart = match.Groups[0].Value;
					} else {
						throw new Exception("Date invalid >" + dateStr);
					}
				}
				dateStr = Regex.Replace(dateStr, datePart, "").Trim();
				datePart = Tools.FormatDate(datePart);
				/// get hour part
				string hourPart = "";
				pattern = @"^\d{1,2}([ .,/:;-]\d{1,2}([ .,/:;-]\d{1,2})?)?"; // Hour format
				regex = new Regex(pattern);
				match = regex.Match(dateStr);
				if (match.Success) {
					hourPart = match.Groups[0].Value;
					hourPart = Regex.Replace(hourPart, @"[ .,/:;-]", ":");
					if (hourPart.Split(':').Length == 1) {
						hourPart += ":00:00";
					} else if (hourPart.Split(':').Length == 2) {
						hourPart += ":00";
					}
				} else {
					hourPart = "00:00:00";
				}
				return DateTime.ParseExact(datePart + " " + hourPart, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
			} catch (Exception) {
				throw;
			}
		}

		private static string FormatDate(string dateStr) {
			dateStr = Regex.Replace(dateStr, @"[ .,/:;-]", "-");
			string[] temp = dateStr.Split('-');
			if (temp[0].Length < 4) {
				string year = temp[2];
				temp[2] = temp[0];
				temp[0] = year;
			}
			return string.Join("-", temp);
		}
	}
}