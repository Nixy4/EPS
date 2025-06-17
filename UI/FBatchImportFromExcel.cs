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
using Entry;
namespace UI
{
    public partial class FBatchImportFromExcel : Form
    {
        public FBatchImportFromExcel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //浏览按钮
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //1.选择模板
                string seletedModuleName = cb_template.Text;   //选择模板的名称
                int seletedModeIndex = cb_template.SelectedIndex;//选择的模板序号，从0开始
                if (seletedModuleName == "")
                {
                    MessageBox.Show("模板必须选择");
                    return;
                }
                //2.打开选择文件的控件
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    tb_fileName.Text = openFileDialog1.FileName;

                    //3.从BLL中读取Excel数据
                    ImportFromExcelBLL ieb = new ImportFromExcelBLL();
                    DataTable dt = ieb.Import(tb_fileName.Text);

                    //4.防止读错模板
                    //4.1约定的字段名称字符串
                    string[] moduleListName = new string[]{
                    "教室编号教室名称类型最大能考人数所在楼名所在楼层",
                    "教师编号教师名称性别"
                };

                    //4.2读取Excel列字符串
                    string readModuleName = "";
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        readModuleName = readModuleName + dt.Columns[i].Caption;
                    }

                    //4.3比较
                    if (moduleListName[seletedModeIndex] != readModuleName)
                    {
                        dgv_info.DataSource = null;
                        lb_show.Text = "共导入【0】条数据";
                        MessageBox.Show("模板错误：选择错误或修改了模板");
                        return;
                    }

                    //5.展示数据
                    dgv_info.DataSource = dt;
                    lb_show.Text = "共导入【" + dt.Rows.Count + "】条数据";
                }
            }
            catch
            {
                MessageBox.Show("操作过程中出现问题。");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1.是否有需要导入的数据
            int dataRowsNumber = dgv_info.Rows.Count;
            int OKNumber = 0;
            if (dataRowsNumber <= 0)
            {
                MessageBox.Show("还没有数据，无法导入，请通过【浏览】选择数据！");
                return;
            }

            //2.对表格中数据一一处理
            ClassRoomModel crm = new ClassRoomModel();//实体类
            ClassRoomBLL crb = new ClassRoomBLL();//BLL类

            for (int i = dataRowsNumber - 1; i >= 0; i--)//从表尾到表头逐一处理
            {
                //2.1把界面上的数据封装到实体类
                crm.ClassRoomID = dgv_info.Rows[i].Cells["教室编号"].Value.ToString();
                crm.ClassRoomName = dgv_info.Rows[i].Cells["教室名称"].Value.ToString();
                crm.ClassRoomType = Convert.ToInt16(dgv_info.Rows[i].Cells["类型"].Value);//"0" "1"
                crm.MaxCapacity = Convert.ToInt16(dgv_info.Rows[i].Cells["最大能考人数"].Value);
                crm.BuildingName = dgv_info.Rows[i].Cells["所在楼名"].Value.ToString();
                crm.Floor = Convert.ToInt16(dgv_info.Rows[i].Cells["所在楼层"].Value);

                //2.2 判断插入状态 插入成功，则删除界面上该记录的行
                if (crb.Insert(crm) == true)
                {
                    OKNumber++;
                    dgv_info.Rows.RemoveAt(i);//2.3删除界面上的index=i的行
                }

                //3.报告处理结果
                lb_show.Text = "此模板共还有【" + dgv_info.Rows.Count + "】条数据未处理";
                MessageBox.Show("任务完成！\r\n成功数量：" + OKNumber);
            }
        }
    }
}
