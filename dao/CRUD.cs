using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace stade.dao {

	public class Crud {
		private static int ID_NUMBER = 4;

		public static string CurrentId(string tableName) { // get the current sequence in table
			DbCommand command = null;
			DbDataReader reader = null;
			try {
				long currId = 0;
				command = DbConnect.Connect().CreateCommand();
				command.CommandText = "select current_value from sys.sequences where name = 's_" + tableName + "'";
				reader = command.ExecuteReader();
				reader.Read();
				currId = reader.IsDBNull(0) ? 1 : reader.GetInt64(0);
				int zeroNb = Crud.ID_NUMBER - currId.ToString().ToCharArray().Length;
				string result = new string(Enumerable.Repeat('0', zeroNb).ToArray()) + currId.ToString();
				return result;
			} catch (Exception e) {
				throw e;
			} finally {
				if (reader != null) { reader.Dispose(); reader.Close(); }
				if (command != null)
					command.Dispose();
			}
		}

		public static int Delete<T>(string table, T condition, DbConnection connection) {
			DbCommand command = null;
			try {
				// create and set SQL command
				string[] tableCols = Crud.GetColsName(table, connection);
				command = connection.CreateCommand();
				command.CommandText = "DELETE from " + table;
				command.CommandText += condition == null ? "" : " WHERE " + Crud.GetNotNullPropValue(condition, tableCols, " AND ");
				// execute command
				return command.ExecuteNonQuery();
			} catch (Exception e) {
				throw e;
			} finally {
				if (command != null)
					command.Dispose();
			}
		}

		public static int Delete<T>(string table, T cond) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				return Crud.Delete(table, cond, connection);
			} catch (Exception e) {
				throw e;
			} finally {
				if (connection != null)
					connection.Close();
			}
		}

		public static int Delete<T>(string table, string condition, DbConnection connection) {
			DbCommand command = null;
			try {
				// create and set SQL command
				string[] tableCols = Crud.GetColsName(table, connection);
				command = connection.CreateCommand();
				command.CommandText = "DELETE from " + table;
				command.CommandText += condition == null ? "" : " WHERE " + condition;
				// execute command
				return command.ExecuteNonQuery();
			} catch (Exception e) {
				throw e;
			} finally {
				if (command != null)
					command.Dispose();
			}
		}

		public static int Delete(string table, string condition) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				return Crud.Delete(table, condition, connection);
			} catch (Exception e) {
				throw e;
			} finally {
				if (connection != null)
					connection.Close();
			}
		}

		public static int ExecuteNonQuery(string query, DbConnection connection) {
			DbCommand command = null;
			try {
				// create and set SQL command
				command = connection.CreateCommand();
				command.CommandText = query;
				// execute command
				return command.ExecuteNonQuery();
			} catch (Exception e) {
				throw e;
			} finally {
				if (command != null)
					command.Dispose();
			}
		}

		public static int ExecuteNonQuery(string query) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				return Crud.ExecuteNonQuery(query, connection);
			} catch (Exception e) {
				throw e;
			} finally {
				if (connection != null)
					connection.Close();
			}
		}

		public static int Insert<T>(string tableName, T obj) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				return Crud.Insert(tableName, obj, connection);
			} catch (Exception e) {
				throw e;
			} finally {
				if (connection != null)
					connection.Close();
			}
		}

		public static int Insert<T>(string tableName, T[] data) {
			DbConnection connection = null;
			try {
				int rowsAffected = 0;
				connection = DbConnect.Connect();
				for (int i = 0; i < data.Length; i++) {
					rowsAffected += Crud.Insert(tableName, data[i], connection);
				}
				return rowsAffected;
			} catch (Exception e) {
				throw e;
			} finally {
				if (connection != null)
					connection.Close();
			}
		}

		public static int Insert<T>(string table, T obj, DbConnection connection) {
			DbCommand command = null;
			try {
				bool propNotFound = true;
				string val = "(";
				string col = "(";
				Type classe = obj.GetType();
				PropertyInfo[] properties = classe.GetProperties();
				string[] tableCols = Crud.GetColsName(table, connection);
				//  set query columns - values
				for (int i = 0; i < tableCols.Length; i++) {
					propNotFound = true;
					for (int j = 0; j < properties.Length; j++) {
						if (properties[j].Name.ToLower().CompareTo(tableCols[i].ToLower()) == 0) {
							col += tableCols[i];
							val += Crud.GetValue(obj, properties[j], table);
							propNotFound = false;
							break;
						}
					}
					if (propNotFound) {
						throw new Exception("Property not found >" + tableCols[i]);
					}
					col += (i == tableCols.Length - 1) ? ")" : ", ";
					val += (i == tableCols.Length - 1) ? ")" : ", ";
				}
				// set command text
				command = connection.CreateCommand();
				command.CommandText = "INSERT INTO " + table + col + " VALUES " + val;
				Console.WriteLine(command.CommandText);
				// execute command
				return command.ExecuteNonQuery();
			} catch (Exception e) {
				throw e;
			} finally {
				if (command != null)
					command.Dispose();
			}
		}

		public static int Insert<T>(string tableName, T[] data, DbConnection connection) {
			try {
				int rowsAffected = 0;
				for (int i = 0; i < data.Length; i++) {
					rowsAffected += Crud.Insert(tableName, data[i], connection);
				}
				return rowsAffected;
			} catch (Exception e) {
				throw e;
			}
		}

		public static string NextId(string tableName, DbConnection connection) {
			DbCommand command = null;
			DbDataReader reader = null;
			try {
				long nextId = 0;
				int zeroNb = 0;
				command = connection.CreateCommand();
				command.CommandText = "SELECT NEXT VALUE FOR s_" + tableName;
				reader = command.ExecuteReader();
				reader.Read();
				nextId = reader.IsDBNull(0) ? 1 : reader.GetInt64(0);
				zeroNb = Crud.ID_NUMBER - nextId.ToString().ToCharArray().Length;
				string result = new string(Enumerable.Repeat('0', zeroNb).ToArray()) + nextId.ToString();
				return result;
			} catch (Exception e) {
				throw e;
			} finally {
				if (reader != null) { reader.Dispose(); reader.Close(); }
				if (command != null) { command.Dispose(); }
			}
		}

		public static T[] Select<T>(string tableName, T obj, string column, string where) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				return Crud.Select(tableName, obj, column, where, connection);
			} catch (Exception e) {
				throw e;
			} finally {
				if (connection != null)
					connection.Close();
			}
		}

		public static T[] Select<T>(string table, T obj, string column, string where, DbConnection connection) {
			DbCommand command = null;
			DbDataReader reader = null;
			try {
				// create and set SQL command
				PropertyInfo property = null;
				Type classe = obj.GetType();
				List<T> result = new List<T>();
				string propType = null;
				object instance = null;
				command = connection.CreateCommand();
				command.CommandText = "SELECT ";
				command.CommandText += (column == null || column == "") ? "*" : column;
				command.CommandText += " FROM " + table;
				command.CommandText += (where == null || where == "") ? "" : " where " + where;
				// execute command
				reader = command.ExecuteReader();
				string columnName = "";
				while (reader.Read()) {
					instance = Activator.CreateInstance(classe);
					for (int i = 0; i < reader.FieldCount; i++) {
						columnName = Crud.UpperFirst(reader.GetName(i).ToString());
						property = classe.GetProperty(columnName);
						if (property == null) {
							continue;
						}
						propType = property.PropertyType.Name;
						try {
							if (propType.Equals("Int32")) {
								property.SetValue(instance, reader.GetInt32(i), null);
							} else if (propType.Equals("Double")) {
								property.SetValue(instance, (double)reader.GetDecimal(i), null);
							} else if (propType.Equals("float")) {
								property.SetValue(instance, reader.GetFloat(i), null);
							} else if (propType.Equals("DateTime")) {
								property.SetValue(instance, reader.GetDateTime(i), null);
							} else if (propType.Equals("String")) {
								property.SetValue(instance, reader.GetString(i), null);
							} else if (propType.Equals("Single")) {
								property.SetValue(instance, Convert.ToSingle(reader.GetDecimal(i)), null);
							} else {
								throw new Exception("Type not found in select !!!");
							}
						} catch (Exception) {
							if (Crud.IsNumber(propType)) {
								property.SetValue(instance, 0, null);
							} else {
								property.SetValue(instance, "", null);
							}
						}
					}
					result.Add((T)instance);
				}
				return result.ToArray();
			} catch (Exception e) {
				throw e;
			} finally {
				if (reader != null) {
					reader.Dispose();
					reader.Close();
				}
				if (command != null)
					command.Dispose();
			}
		}

		public static T[] Select<T>(T obj, string query, DbConnection connection) {
			DbCommand command = null;
			DbDataReader reader = null;
			try {
				// create and set SQL command
				PropertyInfo property = null;
				Type classe = obj.GetType();
				List<T> result = new List<T>();
				string propType = null;
				object instance = null;
				command = connection.CreateCommand();
				command.CommandText = query;
				// execute command
				reader = command.ExecuteReader();
				string columnName = "";
				while (reader.Read()) {
					instance = Activator.CreateInstance(classe);
					for (int i = 0; i < reader.FieldCount; i++) {
						columnName = Crud.UpperFirst(reader.GetName(i).ToString());
						property = classe.GetProperty(columnName);
						if (property == null) {
							continue;
						}
						propType = property.PropertyType.Name;
						try {
							if (propType.Equals("Int32")) {
								property.SetValue(instance, reader.GetInt32(i), null);
							} else if (propType.Equals("Double")) {
								property.SetValue(instance, (double)reader.GetDecimal(i), null);
							} else if (propType.Equals("float")) {
								property.SetValue(instance, reader.GetFloat(i), null);
							} else if (propType.Equals("DateTime")) {
								property.SetValue(instance, reader.GetDateTime(i), null);
							} else if (propType.Equals("String")) {
								property.SetValue(instance, reader.GetString(i), null);
							} else if (propType.Equals("Single")) {
								property.SetValue(instance, Convert.ToSingle(reader.GetDecimal(i)), null);
							} else {
								throw new Exception("Type not found in select !!!");
							}
						} catch (Exception) {
							if (Crud.IsNumber(propType)) {
								property.SetValue(instance, 0, null);
							} else {
								property.SetValue(instance, "", null);
							}
						}
					}
					result.Add((T)instance);
				}
				return result.ToArray();
			} catch (Exception e) {
				throw e;
			} finally {
				if (reader != null) {
					reader.Dispose();
					reader.Close();
				}
				if (command != null)
					command.Dispose();
			}
		}

		public static T[] Select<T>(T obj, string query) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				return Crud.Select(obj, query, connection);
			} catch (Exception e) {
				throw e;
			} finally {
				if (connection != null)
					connection.Close();
			}
		}

		public static T[] SelectFrom<T>(string tableName, T obj, string column, string where) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				return Crud.SelectFrom(tableName, obj, column, where, connection);
			} catch (Exception e) {
				throw e;
			} finally {
				if (connection != null)
					connection.Close();
			}
		}

		public static T[] SelectFrom<T>(string table, T obj, string column, string where, DbConnection connection) {
			DbCommand command = null;
			DbDataReader reader = null;
			try {
				// create and set SQL command
				PropertyInfo property = null;
				Type classe = obj.GetType();
				List<T> result = new List<T>();
				string propType = null;
				object instance = null;
				command = connection.CreateCommand();
				command.CommandText = "SELECT ";
				command.CommandText += (column == null || column == "" ? "*" : column);
				command.CommandText += " FROM " + table;
				command.CommandText += where == null || column == "" ? "" : " " + where;
				// execute command
				reader = command.ExecuteReader();
				string columnName = "";
				while (reader.Read()) {
					instance = Activator.CreateInstance(classe);
					for (int i = 0; i < reader.FieldCount; i++) {
						columnName = Crud.UpperFirst(reader.GetName(i).ToString());
						property = classe.GetProperty(columnName);
						if (property == null) {
							continue;
						}
						propType = property.PropertyType.Name;
						try {
							if (propType.Equals("Int32")) {
								property.SetValue(instance, reader.GetInt32(i), null);
							} else if (propType.Equals("Double")) {
								property.SetValue(instance, (double)reader.GetDecimal(i), null);
							} else if (propType.Equals("float")) {
								property.SetValue(instance, reader.GetFloat(i), null);
							} else if (propType.Equals("DateTime")) {
								property.SetValue(instance, reader.GetDateTime(i), null);
							} else if (propType.Equals("String")) {
								property.SetValue(instance, reader.GetString(i), null);
							} else if (propType.Equals("Single")) {
								property.SetValue(instance, Convert.ToSingle(reader.GetDecimal(i)), null);
							} else {
								throw new Exception("Type not found in select !!!");
							}
						} catch (Exception) {
							if (Crud.IsNumber(propType)) {
								property.SetValue(instance, 0, null);
							} else {
								property.SetValue(instance, "", null);
							}
						}
					}
					result.Add((T)instance);
				}
				return result.ToArray();
			} catch (Exception e) {
				throw e;
			} finally {
				if (reader != null) {
					reader.Dispose();
					reader.Close();
				}
				if (command != null)
					command.Dispose();
			}
		}

		public static int Update(string table, string toUpdate, string condition, DbConnection connection) {
			DbCommand command = null;
			try {
				// create and set SQL command
				command = connection.CreateCommand();
				command.CommandText = "UPDATE " + table + " SET " + toUpdate;
				command.CommandText += condition == null || condition == "" ? "" : " WHERE " + condition;
				// execute command
				return command.ExecuteNonQuery();
			} catch (Exception e) {
				throw e;
			} finally {
				if (command != null)
					command.Dispose();
			}
		}

		public static int Update<T>(string table, T toUpdate, T condition, DbConnection connection) {
			DbCommand command = null;
			try {
				// create and set SQL command
				string[] tableCols = Crud.GetColsName(table, connection);
				command = connection.CreateCommand();
				command.CommandText = "UPDATE " + table + " SET " + Crud.GetNotNullPropValue(toUpdate, tableCols, ", ");
				command.CommandText += condition == null ? "" : " WHERE " + Crud.GetNotNullPropValue(condition, tableCols, " AND ");
				// execute command
				return command.ExecuteNonQuery();
			} catch (Exception e) {
				throw e;
			} finally {
				if (command != null)
					command.Dispose();
			}
		}

		public static int Update(string table, string toUpdate, string condition) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				return Crud.Update(table, toUpdate, condition, connection);
			} catch (Exception e) {
				throw e;
			} finally {
				if (connection != null)
					connection.Close();
			}
		}

		public static int Update<T>(string table, T toUpdate, T condition) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				return Crud.Update(table, toUpdate, condition, connection);
			} catch (Exception e) {
				throw e;
			} finally {
				if (connection != null)
					connection.Close();
			}
		}

		public static string UpperFirst(string str) {
			return str.Substring(0, 1).ToUpper() + str.Substring(1);
		}

		private static string[] GetColsName(string table, DbConnection connection) {
			DbCommand command = null;
			DbDataReader reader = null;
			try {
				List<string> result = new List<string>();
				command = connection.CreateCommand();
				command.CommandText = "SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('" + table + "')";
				reader = command.ExecuteReader();
				while (reader.Read()) {
					result.Add(reader.GetString(0));
				}
				return result.ToArray();
			} catch (Exception) {
				throw;
			} finally {
				if (reader != null) { reader.Dispose(); reader.Close(); }
				if (command != null) { command.Dispose(); }
			}
		}

		private static string GetNotNullPropValue<T>(T obj, string[] tableCols, string sep) {
			try {
				string result = "";
				PropertyInfo[] properties = obj.GetType().GetProperties();
				for (int j = 0; j < tableCols.Length; j++) {
					for (int i = 0; i < properties.Length; i++) {
						if (properties[i].Name.ToLower().CompareTo(tableCols[j].ToLower()) == 0) {
							if (Crud.GetValue(obj, properties[i]) == null || Crud.GetValue(obj, properties[i]) == "0") {
								continue;
							}
							result += Crud.LowerFirst(properties[i].Name);
							result += " = ";
							result += Crud.GetValue(obj, properties[i]);
							result += sep;
							break;
						}
					}
				}
				return result.Substring(0, result.ToCharArray().Length - sep.ToCharArray().Length);
			} catch (Exception) {
				throw;
			}
		}

		private static string GetValue<T>(T obj, PropertyInfo prop, string table) {
			if (prop.Name.StartsWith("Id")) {
				return "'" + Crud.NextId(table, DbConnect.Connect()) + "'";
			}
			string type = prop.PropertyType.Name;
			if (type.Equals("Int32") || type.Equals("Double") || type.Equals("float") || type.Equals("Single")) {
				return prop.GetValue(obj, null).ToString();
			} else if (type.Equals("DateTime") || type.Equals("String")) {
				return "'" + prop.GetValue(obj, null).ToString() + "'";
			} else {
				throw new Exception("property type unrecognized >" + type);
			}
		}

		private static string GetValue<T>(T obj, PropertyInfo prop) {
			string type = prop.PropertyType.Name;
			if (type.Equals("Int32") || type.Equals("Double") || type.Equals("float") || type.Equals("Single")) {
				return prop.GetValue(obj, null).ToString();
			} else if (type.Equals("DateTime") || type.Equals("String")) {
				return (prop.GetValue(obj, null) == null ? null : "'" + prop.GetValue(obj, null).ToString() + "'");
			} else {
				throw new Exception("property type unrecognized >" + type);
			}
		}

		private static bool IsNumber(string type) {
			string[] tabNumber = new string[] { "Int32", "Double", "Float", "Single" };
			for (int i = 0; i < tabNumber.Length; i++) {
				if (tabNumber[i].CompareTo(type) == 0) {
					return true;
				}
			}
			return false;
		}

		private static string LowerFirst(string str) {
			return str.Substring(0, 1).ToLower() + str.Substring(1);
		}

		private void SetParameter<T>(DbCommand command, T obj, string tableName, DbConnection connection) {
			DbParameter parameter = null;
			PropertyInfo[] properties = obj.GetType().GetProperties();
			for (int i = 0; i < properties.Length; i++) {
				parameter = command.CreateParameter();
				parameter.ParameterName = "@" + properties[i].Name;
				parameter.DbType = System.Data.DbType.String;
				parameter.Size = properties[i].GetValue(obj, null) != null ? properties[i].GetValue(obj, null).ToString().Length : 25;
				if (properties[i].Name.StartsWith("id")) {
					//parameter.Value = Crud.nextId(tableName, connection);
				} else {
					parameter.Value = properties[i].GetValue(obj, null);
				}
				command.Parameters.Add(parameter);
			}
		}
	}
}