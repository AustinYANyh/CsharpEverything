namespace Csharp_myeverything
{
    partial class search
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
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_SURE = new System.Windows.Forms.Button();
            this.Search_LAB_PATH = new System.Windows.Forms.Label();
            this.Search_EDI_PATH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.Location = new System.Drawing.Point(219, 101);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(58, 33);
            this.BTN_CANCEL.TabIndex = 10;
            this.BTN_CANCEL.Text = "取消";
            this.BTN_CANCEL.UseVisualStyleBackColor = true;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // BTN_SURE
            // 
            this.BTN_SURE.Location = new System.Drawing.Point(100, 101);
            this.BTN_SURE.Name = "BTN_SURE";
            this.BTN_SURE.Size = new System.Drawing.Size(58, 33);
            this.BTN_SURE.TabIndex = 9;
            this.BTN_SURE.Text = "确定";
            this.BTN_SURE.UseVisualStyleBackColor = true;
            this.BTN_SURE.Click += new System.EventHandler(this.BTN_SURE_Click);
            // 
            // Search_LAB_PATH
            // 
            this.Search_LAB_PATH.AutoSize = true;
            this.Search_LAB_PATH.Location = new System.Drawing.Point(60, 54);
            this.Search_LAB_PATH.Name = "Search_LAB_PATH";
            this.Search_LAB_PATH.Size = new System.Drawing.Size(59, 17);
            this.Search_LAB_PATH.TabIndex = 8;
            this.Search_LAB_PATH.Text = "扫描路径:";
            // 
            // Search_EDI_PATH
            // 
            this.Search_EDI_PATH.Location = new System.Drawing.Point(126, 47);
            this.Search_EDI_PATH.Name = "Search_EDI_PATH";
            this.Search_EDI_PATH.Size = new System.Drawing.Size(185, 24);
            this.Search_EDI_PATH.TabIndex = 7;
            this.Search_EDI_PATH.Tag = "EDI_PATH";
            this.Search_EDI_PATH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_EDI_PATH_KeyDown);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 180);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_SURE);
            this.Controls.Add(this.Search_LAB_PATH);
            this.Controls.Add(this.Search_EDI_PATH);
            this.Name = "search";
            this.Text = "search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_SURE;
        private System.Windows.Forms.Label Search_LAB_PATH;
        private System.Windows.Forms.TextBox Search_EDI_PATH;
    }
}