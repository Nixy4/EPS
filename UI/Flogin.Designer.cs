namespace UI
{
    partial class Flogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_userName = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lb_userName
            // 
            this.lb_userName.Location = new System.Drawing.Point(50, 50);
            this.lb_userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(156, 25);
            this.lb_userName.TabIndex = 0;
            this.lb_userName.TextChanged += new System.EventHandler(this.lb_userName_TextChanged);
           // this.lb_userName.PlaceholderText = "请输入用户名"; // 添加提示字符串
            // 
            // lb_password
            // 
            this.lb_password.Location = new System.Drawing.Point(50, 100);
            this.lb_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(156, 25);
            this.lb_password.TabIndex = 1;
            this.lb_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            //this.lb_password.PlaceholderText = "请输入密码"; // 添加提示字符串
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("宋体", 18F);
            this.btn_login.Location = new System.Drawing.Point(50, 150);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(156, 40);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(this.lb_userName.Width + 100, 250); // 调整窗口大小
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Flogin";
            this.Text = "    登录      ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lb_userName;
        private System.Windows.Forms.TextBox lb_password;
        private System.Windows.Forms.Button btn_login;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}