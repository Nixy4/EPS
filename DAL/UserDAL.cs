using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class UserDAL
    {
        SqlHelper db = new SqlHelper();
        public string GetPassword(string userName)
        {
            //改造SQL语句
            //一类：insert update delete->ExecuteNonQuery()
            //二类:select->ExecuteDataTabel()
            //此写法很容易到SQL注入攻击，解决办法：参数化查询
            string sqlStr = "select * from userInfo where userName=@username";
            SqlParameter[] paras = { new SqlParameter("@username", SqlDbType.VarChar) };
            paras[0].Value = userName;
            DataTable dt = db.ExecuteDataTable(sqlStr, CommandType.Text, paras);
            //此用户不存在
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "Error";
            }
        }
    }
}
