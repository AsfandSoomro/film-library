using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FilmLibrary
{
    class Queries
    {
        public static DataTable GetDataTable(string tableName, string query)
        {
            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, tableName);

                DataTable dataTable = dataSet.Tables[tableName];

                return dataTable;
            }
        }

        public static SqlDataReader GetDataReader(string tableName, string query)
        {
            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                return command.ExecuteReader();
            }
        }
    }
}
