namespace UI
{
    partial class FBatchImportFromExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.lb_show = new System.Windows.Forms.Label();
            this.cb_template = new System.Windows.Forms.ComboBox();
            this.bt_brower = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "对应的`Excel文件：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "模板名称：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_fileName
            // 
            this.tb_fileName.Location = new System.Drawing.Point(184, 15);
            this.tb_fileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.Size = new System.Drawing.Size(354, 25);
            this.tb_fileName.TabIndex = 2;
            this.tb_fileName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_show
            // 
            this.lb_show.AutoSize = true;
            this.lb_show.Location = new System.Drawing.Point(25, 62);
            this.lb_show.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_show.Name = "lb_show";
            this.lb_show.Size = new System.Drawing.Size(37, 15);
            this.lb_show.TabIndex = 3;
            this.lb_show.Text = "提示";
            // 
            // cb_template
            // 
            this.cb_template.FormattingEnabled = true;
            this.cb_template.Items.AddRange(new object[] {
            "教室模块",
            "老师模块",
            "课程模块"});
            this.cb_template.Location = new System.Drawing.Point(660, 15);
            this.cb_template.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_template.Name = "cb_template";
            this.cb_template.Size = new System.Drawing.Size(216, 23);
            this.cb_template.TabIndex = 4;
            this.cb_template.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bt_brower
            // 
            this.bt_brower.Location = new System.Drawing.Point(904, 12);
            this.bt_brower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_brower.Name = "bt_brower";
            this.bt_brower.Size = new System.Drawing.Size(100, 28);
            this.bt_brower.TabIndex = 5;
            this.bt_brower.Text = "浏览...";
            this.bt_brower.UseVisualStyleBackColor = true;
            this.bt_brower.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1024, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "保存数据";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.bt_brower);
            this.panel1.Controls.Add(this.cb_template);
            this.panel1.Controls.Add(this.lb_show);
            this.panel1.Controls.Add(this.tb_fileName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 96);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_info, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 18);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.59657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.40343F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1225, 582);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // dgv_info
            // 
            this.dgv_info.BackgroundColor = System.Drawing.Color.White;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_info.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgv_info.Location = new System.Drawing.Point(4, 105);
            this.dgv_info.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.RowHeadersWidth = 62;
            this.dgv_info.RowTemplate.Height = 23;
            this.dgv_info.Size = new System.Drawing.Size(1217, 474);
            this.dgv_info.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel File |*.xls ";
            // 
            // FBatchImportFromExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FBatchImportFromExcel";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_fileName;
        private System.Windows.Forms.Label lb_show;
        private System.Windows.Forms.ComboBox cb_template;
        private System.Windows.Forms.Button bt_brower;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}