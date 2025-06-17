using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class ImportFromExcelBLL
    {
        public DataTable Import(string filePath)
        {
            ImportFromExcelDAL ifed = new ImportFromExcelDAL();
            return ifed.ImportFromExcel(filePath);
        }
    }
}
