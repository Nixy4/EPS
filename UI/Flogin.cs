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

        private void lb_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // 获取用户信息
            string userName = lb_userName.Text.Trim();
            string userPassword = lb_password.Text.Trim();

            // 验证输入的合理性
            if (userName == "" || userPassword == "")
            {
                MessageBox.Show("用户名或密码不能为空！");
                return;
            }

            // 调用 BLL 方法
            UserBLL ub = new UserBLL();
            bool rs = ub.Check(userName, userPassword);

            if (rs == false)
            {
                MessageBox.Show("登录失败，请检查用户名和密码！");
            }
            else
            {
                MessageBox.Show("登录成功！");
                // 登录成功后，关闭当前登录窗口
                this.Hide();
                // 创建并显示批量导入窗口
                FBatchImportFromExcel batchImportForm = new FBatchImportFromExcel();
                batchImportForm.Show();
            }
        }
    }
}