using stade.dao;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stade.services {

	internal class Tools {

		public static int[] GetNumChaise(string numChaise) {
			try {
				List<string> result = new List<string>();
				string[] temp = null;
				numChaise = numChaise.Trim(';');
				temp = numChaise.Split(';');
				string[] interval = null;
				int debut = 0, fin = 0;
				for (int i = 0; i < temp.Length; i++) {
					interval = temp[i].Trim('-').Split('-');
					if (interval.Length == 0) {
						continue;
					} else if (interval.Length == 1) {
						result.Add(interval[0]);
					} else {
						debut = Convert.ToInt32(interval[0]);
						fin = Convert.ToInt32(interval[1]);
						if (fin < debut) {
							throw new Exception("Chaine invalide >" + numChaise);
						}
						for (int j = debut; j < fin + 1; j++) {
							result.Add(j.ToString());
						}
					}
				}
				return result.Select(x => Convert.ToInt32(x)).ToArray();
			} catch (Exception) {
				throw;
			}
		}

		public static string GetKey(ComboBox c) {
			return ((KeyValuePair<string, string>)c.SelectedItem).Key;
		}

		public static void BindData<T>(ComboBox c, string table, T obj, string where, string key, string value, string selected) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				Tools.BindData(c, table, obj, where, key, value, selected, connection);
			} catch (Exception) {
				throw;
			} finally {
				if (connection != null) {
					connection.Close();
				}
			}
		}

		public static void BindData<T>(ComboBox c, string table, T obj, string where, string key, string value, string selected, DbConnection connection) {
			try {
				List<T> liste = new List<T>(Crud.Select(table, obj, "", where, connection));
				if (liste.Count == 0) {
					return;
				}
				Type type = obj.GetType();
				PropertyInfo keyProperty = type.GetProperty(Crud.UpperFirst(key.ToString()));
				PropertyInfo valueProperty = type.GetProperty(Crud.UpperFirst(value.ToString()));
				Dictionary<string, string> dict = liste.ToDictionary(item => keyProperty.GetValue(item, null).ToString(), item => valueProperty.GetValue(item, null).ToString());
				if (dict.Count() > 0) {
					c.DataSource = new BindingSource(dict, null);
					c.DisplayMember = "Value";
					c.ValueMember = "key";
					try {
						c.SelectedIndex = Convert.ToInt32(selected);
					} catch (InvalidCastException) {
						int index = dict.Keys.ToList().IndexOf(selected);
						if (index < 0) {
							throw new Exception("Key not found >" + selected);
						}
						c.SelectedIndex = index;
					}
				}
			} catch (Exception) {
				throw;
			}
		}

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