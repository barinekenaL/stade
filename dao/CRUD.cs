using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Reflection;
using System.Data.SqlClient;

namespace stade.dao {
    public class CRUD {
        public object[] select(string tableName, object objet, string column, string where, DbConnection connection) {
            DbCommand command = null;
            DbDataReader reader = null;
            string type = null;
            Type classe = null;
            List<object> response = new List<object>();
            object temp = null;
            int nbColumns = 0;
            try {
                // create and set SQL command
                command = connection.CreateCommand();
                command.CommandText = "SELECT ";
                command.CommandText += column == null ? "*" : column;
                command.CommandText += " FROM " + tableName;
                command.CommandText += where == null ? "" : " where " + where;
                // execute command
                reader = command.ExecuteReader();
                string columnName = "";
                // set result
                classe = objet.GetType();
                PropertyInfo property = null;
                while (reader.Read()) {
                    temp = Activator.CreateInstance(classe);
                    nbColumns = reader.FieldCount;
                    for (int i = 0; i < nbColumns; i++) {
                        columnName = reader.GetName(i).ToString().Substring(0, 1).ToUpper() + reader.GetName(i).ToString().Substring(1);
                        property = classe.GetProperty(columnName);
                        try {
                            type = property.PropertyType.Name;
                        } catch (Exception) {
                            int k = 0;
                            k++;
                        }
                        try {
                            if (type.Equals("Int32")) {
                                property.SetValue(temp, reader.GetInt32(i), null);
                            } else if (type.Equals("Double")) {
                                property.SetValue(temp, (double)reader.GetDecimal(i), null);
                            } else if (type.Equals("float")) {
                                property.SetValue(temp, reader.GetFloat(i), null);
                            } else if (type.Equals("DateTime")) {
                                property.SetValue(temp, reader.GetDateTime(i), null);
                            } else if (type.Equals("String")) {
                                property.SetValue(temp, reader.GetString(i), null);
                            } else if (type.Equals("Single")) {
                                property.SetValue(temp, Convert.ToSingle(reader.GetDecimal(i)), null);
                            } else {
                                throw new Exception("Type not found in select !!!");
                            }
                        } catch(Exception) {
                            if(this.isNumber(type)) {
                                property.SetValue(temp, 0, null);
                            } else {
                                property.SetValue(temp, "", null);
                            }
                        }
                    }
                    response.Add(temp);
                }
                return response.ToArray();
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

        public object[] select(string tableName, object objet, string column, string where) {
            DbConnection connection = null;
            try {
                connection = DbConnect.Connect();
                return this.select(tableName, objet, column, where, connection);
            } catch (Exception e) {
                throw e;
            } finally {
                if (connection != null) connection.Close();
            }
        }

        public static string GetValue(object obj, PropertyInfo prop) {
            if (prop.Name.StartsWith("Id")) {
                return new CRUD().nextId(obj.GetType().Name, DbConnect.Connect());
            }
            string type = prop.PropertyType.Name;
            if (type.Equals("Int32") || type.Equals("Double") || type.Equals("float") || type.Equals("Single")) {
                return prop.GetValue(obj, null).ToString();
            } else if (type.Equals("DateTime") || type.Equals("String")) {
                return "'" + prop.GetValue(obj, null).ToString() + "'";
            } else {
                throw new Exception("Type not found in select !!!");
            }
        }

        /*
         * function: INSERT generalisé
         * contrainte: valeurs de tous les attributs non null
         */
        public int insert(string tableName, object aInserer, DbConnection connection) {
            DbCommand command = null;
            PropertyInfo[] properties = null;
            string preparedValue = null;
            try {
                string preparedColumn = null;
                Type classe = null;
                preparedValue = "(";
                preparedColumn = "(";
                classe = aInserer.GetType();
                properties = classe.GetProperties();
                for (int i = 0; i < properties.Length; i++) {
                    preparedColumn += properties[i].Name;
                    preparedValue += CRUD.GetValue(aInserer, properties[i]);
                    preparedColumn += (i == properties.Length - 1) ? ")" : ", ";
                    preparedValue += (i == properties.Length - 1) ? ")" : ", ";
                }
                // set sql command
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO " + tableName + preparedColumn + " VALUES " + preparedValue;

                // set parameters
                //this.setParameter(command, aInserer, tableName, connection);

                // prepare and execute sql
                //command.Prepare();
                return command.ExecuteNonQuery();
            } catch (Exception e) {
                throw e;
            } finally {
                if (command != null)
                    command.Dispose();
            }
        }

        public int insert(string tableName, object aInserer) {
            DbConnection connection = null;
            try {
                connection = DbConnect.Connect();
                return this.insert(tableName, aInserer, connection);
            } catch (Exception e) {
                throw e;
            } finally {
                if (connection != null) connection.Close();
            }
        }

        public int insert(string tableName, object[] data) {
            DbConnection connection = null;
            int rowsAffected = 0;
            try {
                connection = DbConnect.Connect();
                for (int i = 0; i < data.Length; i++) {
                    rowsAffected += this.insert(tableName, data[i], connection);
                }
                return rowsAffected;
            } catch (Exception e) {
                throw e;
            } finally {
                if (connection != null) connection.Close();
            }
        }

        public int insert(string tableName, object[] data, DbConnection connection) {
            int rowsAffected = 0;
            try {
                for (int i = 0; i < data.Length; i++) {
                    rowsAffected += this.insert(tableName, data[i], connection);
                }
                return rowsAffected;
            } catch (Exception e) {
                throw e;
            }
        }

        /*
         * fonction: UPDATE generalisé
         * contrainte: argument condition et toUpdate non null
         */
        public int update(string tableName, string toUpdate, string condition, DbConnection connection) {
            DbCommand command = null;
            try {
                // create and set SQL command
                command = connection.CreateCommand();
                command.CommandText = "UPDATE " + tableName + " SET " + toUpdate;
                command.CommandText += condition == null ? "" : " WHERE " + condition;
                // execute command
                return command.ExecuteNonQuery();
            } catch (Exception e) {
                throw e;
            } finally {
                if (command != null) command.Dispose();
            }

        }

        public int update(string tableName, string toUpdate, string condition) {
            DbConnection connection = null;
            try {
                connection = DbConnect.Connect();
                return this.update(tableName, toUpdate, condition, connection);
            } catch (Exception e) {
                throw e;
            } finally {
                if (connection != null) connection.Close();
            }
        }

        public string nextId(string tableName, DbConnection connection) { // get the next sequence in table
            // ID column name must have the same form like (tableName + ID)
            DbCommand command = null;
            DbDataReader reader = null;
            long nextId = 0;
            try {
                command = connection.CreateCommand();
                command.CommandText = "SELECT NEXT VALUE FOR s_" + tableName;
                reader = command.ExecuteReader();
                reader.Read();
                nextId = reader.IsDBNull(0) ? 1 : reader.GetInt64(0);
                return nextId.ToString();
            } catch (Exception e) {
                throw e;
            } finally {
                if (reader != null) { reader.Dispose(); reader.Close(); }
                if (command != null) command.Dispose();
            }
        }

        public static string currentId(string tableName) { // get the current sequence in table
            DbCommand command = null;
            DbDataReader reader = null;
            try {
                long currId = 0;
                command = DbConnect.Connect().CreateCommand();
                command.CommandText = "select current_value from sys.sequences where name = 's_" + tableName + "'";
                reader = command.ExecuteReader();
                reader.Read();
                currId = reader.IsDBNull(0) ? 1 : reader.GetInt64(0);
                return currId.ToString();
            } catch (Exception e) {
                throw e;
            } finally {
                if (reader != null) { reader.Dispose(); reader.Close(); }
                if (command != null)
                    command.Dispose();
            }
        }

        private void setParameter(DbCommand command, object aInserer, string tableName, DbConnection connection) {
            DbParameter parameter = null;
            PropertyInfo[] properties = aInserer.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++) {
                parameter = command.CreateParameter();
                parameter.ParameterName = "@" + properties[i].Name;
                parameter.DbType = System.Data.DbType.String;
                parameter.Size = properties[i].GetValue(aInserer, null) != null ? properties[i].GetValue(aInserer, null).ToString().Length : 25;
                if (properties[i].Name.StartsWith("id")) {
                    parameter.Value = this.nextId(tableName, connection);
                } else {
                    parameter.Value = properties[i].GetValue(aInserer, null);
                }
                command.Parameters.Add(parameter);
            }
        }

        private bool isNumber(string type) {
            string[] tabNumber = new string[] {"Int32", "Double", "Float", "Single"};
            for (int i = 0; i < tabNumber.Length;i++ ) {
                if(tabNumber[i].CompareTo(type) == 0) {
                    return true;
                }
            }
            return false;
        }
    }


}