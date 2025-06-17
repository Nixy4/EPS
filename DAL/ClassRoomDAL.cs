using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Entry;
using Tools;

namespace DAL
{
    public class ClassRoomDAL
    {
        SqlHelper db = new SqlHelper();
       /// <summary>
       /// 通过教室编号查询教室信息
       /// </summary>
       /// <param name="classRoomID">教室编号</param>
       /// <returns></returns>
        public DataTable Select(string classRoomID)
        {
            string sqlStr = "select * from classRoomInfo where classRoomID=@classRoomID";
            SqlParameter[] paras = {
                                       new SqlParameter("@classRoomID",SqlDbType.VarChar)
                                   };
            paras[0].Value = classRoomID;
            return db.ExecuteDataTable(sqlStr, CommandType.Text, paras);
        }
       /// <summary>
       /// 插入教室信息
       /// </summary>
       /// <param name="crm">教室实体信息</param>
       /// <returns></returns>
        public int Insert(ClassRoomModel crm)
        {
            string sqlStr = "insert into classRoomInfo values(@classRoomID,@classRoomName,@classRoomType,@maxCapacity,@buildingName,@floor)";
            SqlParameter[] paras = {
                                       new SqlParameter("@classRoomID",SqlDbType.VarChar),
                                       new SqlParameter("@classRoomName",SqlDbType.VarChar),
                                       new SqlParameter("@classRoomType",SqlDbType.Int),
                                       new SqlParameter("@maxCapacity",SqlDbType.Int),
                                       new SqlParameter("@buildingName",SqlDbType.VarChar),
                                       new SqlParameter("@floor",SqlDbType.Int),
                                   };
            paras[0].Value = crm.ClassRoomID;
            paras[0].Value = crm.ClassRoomName;
            paras[0].Value = crm.ClassRoomType;
            paras[0].Value = crm.MaxCapacity;
            paras[0].Value = crm.BuildingName;
            paras[0].Value = crm.Floor;
            return db.ExecuteNonQuery(sqlStr, CommandType.Text, paras);
        }
    }
}
