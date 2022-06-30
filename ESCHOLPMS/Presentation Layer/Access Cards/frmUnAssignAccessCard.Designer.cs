namespace ESCHOLPMS 
{
    partial class frmUnAssignAccessCard
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
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblCardNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtCardNumber = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.btnFetch = new Syncfusion.WinForms.Controls.SfButton();
            this.lblWorkerName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblWorkerNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblWorker = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblWorkerID = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblToInactivate = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblReUsable = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnConfirm = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.rdYesWorkerInactive = new System.Windows.Forms.RadioButton();
            this.rdNoWorkerInactive = new System.Windows.Forms.RadioButton();
            this.rdYesReUsable = new System.Windows.Forms.RadioButton();
            this.rdNoReUsable = new System.Windows.Forms.RadioButton();
            this.groupWorkerInactive = new System.Windows.Forms.GroupBox();
            this.groupCardUsable = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.lblPhotoFileName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNumber)).BeginInit();
            this.groupWorkerInactive.SuspendLayout();
            this.groupCardUsable.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Red;
            this.autoLabel1.Location = new System.Drawing.Point(270, 21);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(277, 27);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Un-Assign Access Card";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(13, 97);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(121, 19);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "Card Number ?";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BeforeTouchSize = new System.Drawing.Size(121, 27);
            this.txtCardNumber.IntegerValue = ((long)(1));
            this.txtCardNumber.Location = new System.Drawing.Point(140, 90);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.NumberGroupSeparator = "";
            this.txtCardNumber.Size = new System.Drawing.Size(121, 27);
            this.txtCardNumber.TabIndex = 3;
            this.txtCardNumber.Text = "1";
            // 
            // btnFetch
            // 
            this.btnFetch.AccessibleName = "Button";
            this.btnFetch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnFetch.Location = new System.Drawing.Point(281, 90);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(96, 28);
            this.btnFetch.TabIndex = 4;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.ForeColor = System.Drawing.Color.Blue;
            this.lblWorkerName.Location = new System.Drawing.Point(140, 150);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(51, 19);
            this.lblWorkerName.TabIndex = 5;
            this.lblWorkerName.Text = "Name";
            // 
            // lblWorkerNumber
            // 
            this.lblWorkerNumber.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerNumber.ForeColor = System.Drawing.Color.Blue;
            this.lblWorkerNumber.Location = new System.Drawing.Point(140, 209);
            this.lblWorkerNumber.Name = "lblWorkerNumber";
            this.lblWorkerNumber.Size = new System.Drawing.Size(103, 19);
            this.lblWorkerNumber.TabIndex = 6;
            this.lblWorkerNumber.Text = "WorkerCode";
            // 
            // lblWorker
            // 
            this.lblWorker.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.Location = new System.Drawing.Point(13, 150);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(116, 19);
            this.lblWorker.TabIndex = 7;
            this.lblWorker.Text = "Worker Name ";
            // 
            // lblWorkerID
            // 
            this.lblWorkerID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerID.Location = new System.Drawing.Point(18, 209);
            this.lblWorkerID.Name = "lblWorkerID";
            this.lblWorkerID.Size = new System.Drawing.Size(108, 19);
            this.lblWorkerID.TabIndex = 8;
            this.lblWorkerID.Text = "Worker Code";
            // 
            // lblToInactivate
            // 
            this.lblToInactivate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToInactivate.Location = new System.Drawing.Point(18, 308);
            this.lblToInactivate.Name = "lblToInactivate";
            this.lblToInactivate.Size = new System.Drawing.Size(305, 19);
            this.lblToInactivate.TabIndex = 9;
            this.lblToInactivate.Text = "Do You Want To Make Worker Inactive ?";
            // 
            // lblReUsable
            // 
            this.lblReUsable.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReUsable.Location = new System.Drawing.Point(16, 400);
            this.lblReUsable.Name = "lblReUsable";
            this.lblReUsable.Size = new System.Drawing.Size(245, 19);
            this.lblReUsable.TabIndex = 10;
            this.lblReUsable.Text = "Is this Access Card Re-Usable ?";
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleName = "Button";
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnConfirm.Location = new System.Drawing.Point(165, 501);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(96, 28);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(520, 491);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rdYesWorkerInactive
            // 
            this.rdYesWorkerInactive.AutoSize = true;
            this.rdYesWorkerInactive.Location = new System.Drawing.Point(6, 26);
            this.rdYesWorkerInactive.Name = "rdYesWorkerInactive";
            this.rdYesWorkerInactive.Size = new System.Drawing.Size(55, 26);
            this.rdYesWorkerInactive.TabIndex = 13;
            this.rdYesWorkerInactive.TabStop = true;
            this.rdYesWorkerInactive.Text = "Yes";
            this.rdYesWorkerInactive.UseVisualStyleBackColor = true;
            // 
            // rdNoWorkerInactive
            // 
            this.rdNoWorkerInactive.AutoSize = true;
            this.rdNoWorkerInactive.Location = new System.Drawing.Point(119, 24);
            this.rdNoWorkerInactive.Name = "rdNoWorkerInactive";
            this.rdNoWorkerInactive.Size = new System.Drawing.Size(49, 26);
            this.rdNoWorkerInactive.TabIndex = 14;
            this.rdNoWorkerInactive.TabStop = true;
            this.rdNoWorkerInactive.Text = "No";
            this.rdNoWorkerInactive.UseVisualStyleBackColor = true;
            // 
            // rdYesReUsable
            // 
            this.rdYesReUsable.AutoSize = true;
            this.rdYesReUsable.Location = new System.Drawing.Point(6, 26);
            this.rdYesReUsable.Name = "rdYesReUsable";
            this.rdYesReUsable.Size = new System.Drawing.Size(55, 26);
            this.rdYesReUsable.TabIndex = 15;
            this.rdYesReUsable.TabStop = true;
            this.rdYesReUsable.Text = "Yes";
            this.rdYesReUsable.UseVisualStyleBackColor = true;
            // 
            // rdNoReUsable
            // 
            this.rdNoReUsable.AutoSize = true;
            this.rdNoReUsable.Location = new System.Drawing.Point(119, 26);
            this.rdNoReUsable.Name = "rdNoReUsable";
            this.rdNoReUsable.Size = new System.Drawing.Size(49, 26);
            this.rdNoReUsable.TabIndex = 16;
            this.rdNoReUsable.TabStop = true;
            this.rdNoReUsable.Text = "No";
            this.rdNoReUsable.UseVisualStyleBackColor = true;
            // 
            // groupWorkerInactive
            // 
            this.groupWorkerInactive.Controls.Add(this.rdYesWorkerInactive);
            this.groupWorkerInactive.Controls.Add(this.rdNoWorkerInactive);
            this.groupWorkerInactive.Location = new System.Drawing.Point(329, 275);
            this.groupWorkerInactive.Name = "groupWorkerInactive";
            this.groupWorkerInactive.Size = new System.Drawing.Size(200, 65);
            this.groupWorkerInactive.TabIndex = 17;
            this.groupWorkerInactive.TabStop = false;
            this.groupWorkerInactive.Visible = false;
            // 
            // groupCardUsable
            // 
            this.groupCardUsable.Controls.Add(this.rdYesReUsable);
            this.groupCardUsable.Controls.Add(this.rdNoReUsable);
            this.groupCardUsable.Location = new System.Drawing.Point(329, 367);
            this.groupCardUsable.Name = "groupCardUsable";
            this.groupCardUsable.Size = new System.Drawing.Size(200, 67);
            this.groupCardUsable.TabIndex = 18;
            this.groupCardUsable.TabStop = false;
            this.groupCardUsable.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picPhoto);
            this.panel1.Location = new System.Drawing.Point(535, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 258);
            this.panel1.TabIndex = 19;
            // 
            // picPhoto
            // 
            this.picPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPhoto.Location = new System.Drawing.Point(0, 0);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(253, 258);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // lblPhotoFileName
            // 
            this.lblPhotoFileName.AutoSize = true;
            this.lblPhotoFileName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoFileName.Location = new System.Drawing.Point(565, 340);
            this.lblPhotoFileName.Name = "lblPhotoFileName";
            this.lblPhotoFileName.Size = new System.Drawing.Size(110, 19);
            this.lblPhotoFileName.TabIndex = 20;
            this.lblPhotoFileName.Text = "PhotFileName";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(611, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(177, 34);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.Visible = false;
            // 
            // frmUnAssignAccessCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPhotoFileName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupCardUsable);
            this.Controls.Add(this.groupWorkerInactive);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblReUsable);
            this.Controls.Add(this.lblToInactivate);
            this.Controls.Add(this.lblWorkerID);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblWorkerNumber);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUnAssignAccessCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Un-Assign Card";
            this.Load += new System.EventHandler(this.frmUnAssignAccessCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNumber)).EndInit();
            this.groupWorkerInactive.ResumeLayout(false);
            this.groupWorkerInactive.PerformLayout();
            this.groupCardUsable.ResumeLayout(false);
            this.groupCardUsable.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCardNumber;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtCardNumber;
        private Syncfusion.WinForms.Controls.SfButton btnFetch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblWorkerName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblWorkerNumber;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblWorker;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblWorkerID;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblToInactivate;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblReUsable;
        private Syncfusion.WinForms.Controls.SfButton btnConfirm;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private System.Windows.Forms.RadioButton rdYesWorkerInactive;
        private System.Windows.Forms.RadioButton rdNoWorkerInactive;
        private System.Windows.Forms.RadioButton rdYesReUsable;
        private System.Windows.Forms.RadioButton rdNoReUsable;
        private System.Windows.Forms.GroupBox groupWorkerInactive;
        private System.Windows.Forms.GroupBox groupCardUsable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Label lblPhotoFileName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}