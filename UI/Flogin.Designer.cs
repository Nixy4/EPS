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
            this.lb_login = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lb_userName
            // 
            this.lb_userName.Location = new System.Drawing.Point(948, 202);
            this.lb_userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(156, 25);
            this.lb_userName.TabIndex = 0;
            this.lb_userName.TextChanged += new System.EventHandler(this.lb_userName_TextChanged);
            // 
            // lb_password
            // 
            this.lb_password.Location = new System.Drawing.Point(948, 253);
            this.lb_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(156, 25);
            this.lb_password.TabIndex = 1;
            this.lb_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.BackColor = System.Drawing.Color.Transparent;
            this.lb_login.Font = new System.Drawing.Font("宋体", 18F);
            this.lb_login.Location = new System.Drawing.Point(909, 352);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(0, 30);
            this.lb_login.TabIndex = 2;
            this.lb_login.Click += new System.EventHandler(this.lb_login_Click);
            // 
            // Flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(1213, 522);
            this.Controls.Add(this.lb_login);
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
        private System.Windows.Forms.Label lb_login;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

