using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace MyTasksManager.DataAccess
{
    public class SqlDataAccess
    {
        public static string GetConnectionString(string connectionName = "TasksManagerDB")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }

        public static int Execute(string sql)
        {
            using (SqlConnection cnn = new SqlConnection(GetConnectionString()))
            using (var cmd = cnn.CreateCommand())
            {
                int success = 0;
                cnn.Open();
                cmd.CommandText = sql;
                try
                {
                    cmd.ExecuteNonQuery();
                    success = 1;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString(), ex);
                }
                finally
                {
                    cnn.Close();
                }
                return success;

            }
        }

    }
}