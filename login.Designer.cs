namespace Csharp_myeverything
{
    partial class login
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
            this.LAB_USERNAME = new System.Windows.Forms.Label();
            this.LAB_PASSWD = new System.Windows.Forms.Label();
            this.EDI_USERNAME = new System.Windows.Forms.TextBox();
            this.EDI_PASSWD = new System.Windows.Forms.TextBox();
            this.BTN_LOGIN = new System.Windows.Forms.Button();
            this.BTN_LOGCANCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAB_USERNAME
            // 
            this.LAB_USERNAME.AutoSize = true;
            this.LAB_USERNAME.Location = new System.Drawing.Point(76, 47);
            this.LAB_USERNAME.Name = "LAB_USERNAME";
            this.LAB_USERNAME.Size = new System.Drawing.Size(47, 17);
            this.LAB_USERNAME.TabIndex = 0;
            this.LAB_USERNAME.Text = "用户名:";
            this.LAB_USERNAME.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LAB_PASSWD
            // 
            this.LAB_PASSWD.AutoSize = true;
            this.LAB_PASSWD.Location = new System.Drawing.Point(76, 80);
            this.LAB_PASSWD.Name = "LAB_PASSWD";
            this.LAB_PASSWD.Size = new System.Drawing.Size(35, 17);
            this.LAB_PASSWD.TabIndex = 1;
            this.LAB_PASSWD.Text = "密码:";
            this.LAB_PASSWD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EDI_USERNAME
            // 
            this.EDI_USERNAME.Location = new System.Drawing.Point(141, 43);
            this.EDI_USERNAME.Name = "EDI_USERNAME";
            this.EDI_USERNAME.Size = new System.Drawing.Size(160, 24);
            this.EDI_USERNAME.TabIndex = 2;
            // 
            // EDI_PASSWD
            // 
            this.EDI_PASSWD.Location = new System.Drawing.Point(141, 77);
            this.EDI_PASSWD.Name = "EDI_PASSWD";
            this.EDI_PASSWD.Size = new System.Drawing.Size(160, 24);
            this.EDI_PASSWD.TabIndex = 3;
            this.EDI_PASSWD.UseSystemPasswordChar = true;
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.Location = new System.Drawing.Point(118, 130);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(51, 23);
            this.BTN_LOGIN.TabIndex = 4;
            this.BTN_LOGIN.Text = "登录";
            this.BTN_LOGIN.UseVisualStyleBackColor = true;
            this.BTN_LOGIN.Click += new System.EventHandler(this.BTN_LOGIN_Click);
            // 
            // BTN_LOGCANCEL
            // 
            this.BTN_LOGCANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_LOGCANCEL.Location = new System.Drawing.Point(225, 130);
            this.BTN_LOGCANCEL.Name = "BTN_LOGCANCEL";
            this.BTN_LOGCANCEL.Size = new System.Drawing.Size(51, 23);
            this.BTN_LOGCANCEL.TabIndex = 5;
            this.BTN_LOGCANCEL.Text = "取消";
            this.BTN_LOGCANCEL.UseVisualStyleBackColor = true;
            this.BTN_LOGCANCEL.Click += new System.EventHandler(this.BTN_LOGCANCEL_Click);
            // 
            // login
            // 
            this.AcceptButton = this.BTN_LOGIN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_LOGCANCEL;
            this.ClientSize = new System.Drawing.Size(378, 193);
            this.Controls.Add(this.BTN_LOGCANCEL);
            this.Controls.Add(this.BTN_LOGIN);
            this.Controls.Add(this.EDI_PASSWD);
            this.Controls.Add(this.EDI_USERNAME);
            this.Controls.Add(this.LAB_PASSWD);
            this.Controls.Add(this.LAB_USERNAME);
            this.KeyPreview = true;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAB_USERNAME;
        private System.Windows.Forms.Label LAB_PASSWD;
        private System.Windows.Forms.TextBox EDI_USERNAME;
        private System.Windows.Forms.TextBox EDI_PASSWD;
        private System.Windows.Forms.Button BTN_LOGIN;
        private System.Windows.Forms.Button BTN_LOGCANCEL;
    }
}