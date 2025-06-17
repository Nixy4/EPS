using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //登录按钮S
        private void lb_login_Click(object sender, EventArgs e)
        {
            //获取用户信息
            string userName = lb_userName.Text.Trim();
            string userPassword = lb_password.Text.Trim();
            //验证输入的合理性
            if (userName == "" || userPassword == "")
            {
                MessageBox.Show("用户名或密码不能为空！");
                return;
            }
            //调用BLL方法
            UserBLL ub = new UserBLL();
            bool rs = ub.Check(userName, userPassword);
            if (rs == false)
            {
                //跳转到相应的界面
                MessageBox.Show("NO");
            }
            else
            {
                MessageBox.Show("OK");
            }
        }

        private void lb_userName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
