namespace Hard_Lock
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBoxAuthentication = new System.Windows.Forms.GroupBox();
            this.lnkHELP = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBoxMainArea = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLable1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxAuthentication.SuspendLayout();
            this.groupBoxMainArea.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAuthentication
            // 
            this.groupBoxAuthentication.Controls.Add(this.lnkHELP);
            this.groupBoxAuthentication.Controls.Add(this.btnCancel);
            this.groupBoxAuthentication.Controls.Add(this.label2);
            this.groupBoxAuthentication.Controls.Add(this.txtPassword);
            this.groupBoxAuthentication.Controls.Add(this.label1);
            this.groupBoxAuthentication.Controls.Add(this.txtUserName);
            this.groupBoxAuthentication.Controls.Add(this.btnLogin);
            this.groupBoxAuthentication.Location = new System.Drawing.Point(8, 5);
            this.groupBoxAuthentication.Name = "groupBoxAuthentication";
            this.groupBoxAuthentication.Size = new System.Drawing.Size(315, 103);
            this.groupBoxAuthentication.TabIndex = 0;
            this.groupBoxAuthentication.TabStop = false;
            this.groupBoxAuthentication.Text = "Authentication";
            // 
            // lnkHELP
            // 
            this.lnkHELP.AutoSize = true;
            this.lnkHELP.Location = new System.Drawing.Point(13, 77);
            this.lnkHELP.Name = "lnkHELP";
            this.lnkHELP.Size = new System.Drawing.Size(108, 13);
            this.lnkHELP.TabIndex = 3;
            this.lnkHELP.TabStop = true;
            this.lnkHELP.Text = "About this Software...";
            this.lnkHELP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHELP_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(153, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "UserName:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(79, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(230, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(79, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '●';
            this.txtUserName.Size = new System.Drawing.Size(230, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(234, 72);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBoxMainArea
            // 
            this.groupBoxMainArea.Controls.Add(this.label3);
            this.groupBoxMainArea.Controls.Add(this.button1);
            this.groupBoxMainArea.Controls.Add(this.btnClear);
            this.groupBoxMainArea.Controls.Add(this.btnGenerate);
            this.groupBoxMainArea.Enabled = false;
            this.groupBoxMainArea.Location = new System.Drawing.Point(8, 114);
            this.groupBoxMainArea.Name = "groupBoxMainArea";
            this.groupBoxMainArea.Size = new System.Drawing.Size(315, 129);
            this.groupBoxMainArea.TabIndex = 1;
            this.groupBoxMainArea.TabStop = false;
            this.groupBoxMainArea.Text = "Main Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 52);
            this.label3.TabIndex = 3;
            this.label3.Text = "Help:\r\nFor lock press \"Generate Lock\" \r\nFor Unlock press \"Clear Lock\"\r\nFor Checki" +
                "ng the computer lock status press \"Check Lock\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check Lock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(127, 100);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Lock";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(221, 100);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(88, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Lock";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLable1});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 253);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(331, 18);
            this.statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 13);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // toolStripStatusLable1
            // 
            this.toolStripStatusLable1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolStripStatusLable1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLable1.Name = "toolStripStatusLable1";
            this.toolStripStatusLable1.Size = new System.Drawing.Size(99, 13);
            this.toolStripStatusLable1.Text = "Not Authenticated!";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(331, 271);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxMainArea);
            this.Controls.Add(this.groupBoxAuthentication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hard Lock - Intelligence  Systems Co.";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.groupBoxAuthentication.ResumeLayout(false);
            this.groupBoxAuthentication.PerformLayout();
            this.groupBoxMainArea.ResumeLayout(false);
            this.groupBoxMainArea.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAuthentication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBoxMainArea;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLable1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lnkHELP;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

