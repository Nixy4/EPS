using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Tools;
namespace BLL

{
    public class UserBLL
    {
        //添加用户
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName">用户编号</param>
        /// <param name="password">明文密码</param>
        /// <returns>true 身份验证通过，false 身份验证不通过</returns>
        public bool Check(string userName, string password)
        {
            //Security sec = new Security();
            //UserDAL ud = new UserDAL();
            //string returnPassword = ud.GetPassword(userName);
            //if (returnPassword == sec.MD5(password))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            string defaultUserName = "admin"; // 默认用户名
            string defaultPassword = "123"; // 默认密码
            if (userName == defaultUserName && password == defaultPassword)
            {
                return true; // 验证通过
            }
            else
            {
                return false; // 验证不通过
            }
        }
    }
}
