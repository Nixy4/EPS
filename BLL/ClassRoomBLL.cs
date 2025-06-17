using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Entry;
using System.Data;

namespace BLL
{
    public class ClassRoomBLL
    {
        ClassRoomDAL crd = new ClassRoomDAL();

        public bool Insert(ClassRoomModel crm)
        {

            DataTable dt = crd.Select(crm.ClassRoomID);
            if (dt.Rows.Count > 0)
            {
                return false;
            }

            if (crd.Insert(crm) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
