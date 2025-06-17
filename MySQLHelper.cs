using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace Test20250320
{
    public static class MySQLHelper
    {
        private static string connectionString;

        static MySQLHelper()
        {
            // 从配置文件中读取连接字符串
            connectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        }

        /// <summary>
        /// 设置或获取数据库连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get => connectionString;
            set => connectionString = value;
        }

        /// <summary>
        /// 创建MySql参数
        /// </summary>
        public static MySqlParameter CreateParameter(string name, MySqlDbType type, object value)
        {
            return new MySqlParameter(name, type) { Value = value };
        }

        /// <summary>
        /// 执行非查询SQL语句
        /// </summary>
        public static int ExecuteNonQuery(string commandText,
            MySqlParameter[] parameters = null,
            CommandType commandType = CommandType.Text)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand(commandText, connection))
            {
                command.CommandType = commandType;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 执行查询并返回DataTable
        /// </summary>
        public static DataTable ExecuteDataTable(string commandText,MySqlParameter[] parameters = null,CommandType commandType = CommandType.Text)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand(commandText, connection))
            {
                command.CommandType = commandType;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (var adapter = new MySqlDataAdapter(command))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// 执行查询并返回第一行第一列
        /// </summary>
        public static object ExecuteScalar(string commandText,
            MySqlParameter[] parameters = null,
            CommandType commandType = CommandType.Text)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand(commandText, connection))
            {
                command.CommandType = commandType;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                connection.Open();
                return command.ExecuteScalar();
            }
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        public static DataTable ExecuteStoredProcedure(string procedureName,
            MySqlParameter[] parameters = null)
        {
            return ExecuteDataTable(procedureName, parameters, CommandType.StoredProcedure);
        }
    }
}