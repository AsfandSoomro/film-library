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
        public async static Task<DataTable> GetDataTable(string tableName, string query)
        {
            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                await conn.OpenAsync();

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, tableName);

                DataTable dataTable = dataSet.Tables[tableName];

                return dataTable;
            }
        }

        public async static Task<DataTable> GetDataTable(string tableName)
        {
            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                await conn.OpenAsync();

                SqlCommand command = new SqlCommand(String.Format("SELECT * FROM {0}", tableName), conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, tableName);

                DataTable dataTable = dataSet.Tables[tableName];

                return dataTable;
            }
        }

        public static DataTable GetDataTableNonAsync(string tableName, string query)
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

        public async static Task<int> GetCountRows(string tableName, string condition)
        {
            string query = String.Format("SELECT COUNT(*) FROM {0} WHERE {1}", tableName, condition);
            int count = 0;

            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                await conn.OpenAsync();

                SqlCommand command = new SqlCommand(query, conn);

                object value = command.ExecuteScalar();
                if (value != null) count = (int) value;

                return count;
            }
        }

        public async static Task<int> GetCountRows(string tableName)
        {
            string query = String.Format("SELECT COUNT(*) FROM {0}", tableName);
            int count = 0;

            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                await conn.OpenAsync();

                SqlCommand command = new SqlCommand(query, conn);

                object value = command.ExecuteScalar();
                if (value != null) count = (int)value;

                return count;
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

        public static void InsertRow(string query)
        {
            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public async static void DeleteRows(string query)
        {
            using (SqlConnection conn = new SqlConnection(Program.MyConnectionString))
            {
                await conn.OpenAsync();

                SqlCommand command = new SqlCommand(query, conn);

                command.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}
