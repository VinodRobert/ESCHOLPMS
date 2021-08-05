namespace ESCHOLPMS
{
    partial class frmLogin
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblPassword = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblConnectVia = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtUserName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.rdLan = new System.Windows.Forms.RadioButton();
            this.rdRemote = new System.Windows.Forms.RadioButton();
            this.btnLogin = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Access Managemnet System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ESCHOLPMS.Properties.Resources.KEY;
            this.pictureBox2.Location = new System.Drawing.Point(430, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 274);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ESCHOLPMS.Properties.Resources.Vettoor_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(5, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(17, 77);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(103, 20);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(17, 149);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblConnectVia
            // 
            this.lblConnectVia.Location = new System.Drawing.Point(13, 216);
            this.lblConnectVia.Name = "lblConnectVia";
            this.lblConnectVia.Size = new System.Drawing.Size(107, 20);
            this.lblConnectVia.TabIndex = 5;
            this.lblConnectVia.Text = "Connect By";
            // 
            // txtUserName
            // 
            this.txtUserName.BeforeTouchSize = new System.Drawing.Size(243, 28);
            this.txtUserName.Location = new System.Drawing.Point(169, 77);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(243, 28);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.Text = "textBoxExt1";
            // 
            // txtPassword
            // 
            this.txtPassword.BeforeTouchSize = new System.Drawing.Size(243, 28);
            this.txtPassword.Location = new System.Drawing.Point(169, 141);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(243, 28);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "textBoxExt1";
            // 
            // rdLan
            // 
            this.rdLan.AutoSize = true;
            this.rdLan.Location = new System.Drawing.Point(169, 212);
            this.rdLan.Name = "rdLan";
            this.rdLan.Size = new System.Drawing.Size(64, 24);
            this.rdLan.TabIndex = 8;
            this.rdLan.TabStop = true;
            this.rdLan.Text = "LAN";
            this.rdLan.UseVisualStyleBackColor = true;
            // 
            // rdRemote
            // 
            this.rdRemote.AutoSize = true;
            this.rdRemote.Location = new System.Drawing.Point(304, 212);
            this.rdRemote.Name = "rdRemote";
            this.rdRemote.Size = new System.Drawing.Size(96, 24);
            this.rdRemote.TabIndex = 9;
            this.rdRemote.TabStop = true;
            this.rdRemote.Text = "Remote";
            this.rdRemote.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleName = "Button";
            this.btnLogin.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnLogin.Location = new System.Drawing.Point(169, 256);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 28);
            this.btnLogin.Style.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.BackColor = System.Drawing.Color.Lavender;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(316, 256);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.Style.BackColor = System.Drawing.Color.Lavender;
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 394);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.rdRemote);
            this.Controls.Add(this.rdLan);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblConnectVia);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblUserName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblPassword;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblConnectVia;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUserName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private System.Windows.Forms.RadioButton rdLan;
        private System.Windows.Forms.RadioButton rdRemote;
        private Syncfusion.WinForms.Controls.SfButton btnLogin;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}

