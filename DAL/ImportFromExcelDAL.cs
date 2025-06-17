using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Tools;

namespace DAL
{
    public class ImportFromExcelDAL
    {
        /// <summary>
        /// 从Excel中读取内容
        /// </summary>
        /// <param name="filePath">模板的路径和名称</param>
        /// <returns>数据表</returns>
        public DataTable ImportFromExcel(string filePath)
        {
            DataTable dt = ExcelHelper.Import(filePath);
            if (dt == null)
            {
                Console.WriteLine("ImportFromExcelDAL.ImportFromExcel: dt is null, filePath = " + filePath);
                return null; // 如果读取失败，返回null
            }
            else
            {
                Console.WriteLine("ImportFromExcelDAL.ImportFromExcel: dt is not null, filePath = " + filePath);
                return dt;
            }
        }
    }
}
