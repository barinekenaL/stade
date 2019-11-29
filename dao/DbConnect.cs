using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;

namespace stade.dao {
    public class DbConnect {
        public static SqlConnection Connect() {
            SqlConnection connection = null;
            try {
                connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\B\OneDrive\Documents\ITUniversity\s5\arch-log\stade\db.mdf;Integrated Security=True");
                connection.Open();
                return connection;
            } catch(SqlException e) {
                throw e;
            }
        }
    }
}
