namespace ESCHOLPMS 
{
    partial class frmAssignAccessCard
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
            this.btnFetchCard = new Syncfusion.WinForms.Controls.SfButton();
            this.lblWorkerName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblWorker = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblWorkerID = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnConfirm = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.lblTrade = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblTradeName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.txtWorkerNumber = new System.Windows.Forms.TextBox();
            this.btnFetchLabour = new Syncfusion.WinForms.Controls.SfButton();
            this.lblInstruction = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPhotoFileName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNumber)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Red;
            this.autoLabel1.Location = new System.Drawing.Point(278, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(237, 27);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Assign Access Card";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(5, 64);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(121, 19);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "Card Number ?";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BeforeTouchSize = new System.Drawing.Size(121, 27);
            this.txtCardNumber.IntegerValue = ((long)(1));
            this.txtCardNumber.Location = new System.Drawing.Point(140, 56);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.NumberGroupSeparator = "";
            this.txtCardNumber.Size = new System.Drawing.Size(121, 27);
            this.txtCardNumber.TabIndex = 3;
            this.txtCardNumber.Text = "1";
            // 
            // btnFetchCard
            // 
            this.btnFetchCard.AccessibleName = "Button";
            this.btnFetchCard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnFetchCard.Location = new System.Drawing.Point(343, 55);
            this.btnFetchCard.Name = "btnFetchCard";
            this.btnFetchCard.Size = new System.Drawing.Size(96, 28);
            this.btnFetchCard.TabIndex = 4;
            this.btnFetchCard.Text = "Fetch Card";
            this.btnFetchCard.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.ForeColor = System.Drawing.Color.Blue;
            this.lblWorkerName.Location = new System.Drawing.Point(149, 238);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(51, 19);
            this.lblWorkerName.TabIndex = 5;
            this.lblWorkerName.Text = "Name";
            // 
            // lblWorker
            // 
            this.lblWorker.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.Location = new System.Drawing.Point(10, 238);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(116, 19);
            this.lblWorker.TabIndex = 7;
            this.lblWorker.Text = "Worker Name ";
            // 
            // lblWorkerID
            // 
            this.lblWorkerID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerID.Location = new System.Drawing.Point(5, 117);
            this.lblWorkerID.Name = "lblWorkerID";
            this.lblWorkerID.Size = new System.Drawing.Size(108, 19);
            this.lblWorkerID.TabIndex = 8;
            this.lblWorkerID.Text = "Worker Code";
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleName = "Button";
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnConfirm.Location = new System.Drawing.Point(140, 409);
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
            this.btnClose.Location = new System.Drawing.Point(525, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTrade
            // 
            this.lblTrade.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrade.Location = new System.Drawing.Point(12, 314);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(50, 19);
            this.lblTrade.TabIndex = 13;
            this.lblTrade.Text = "Trade";
            // 
            // lblTradeName
            // 
            this.lblTradeName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTradeName.ForeColor = System.Drawing.Color.Blue;
            this.lblTradeName.Location = new System.Drawing.Point(150, 314);
            this.lblTradeName.Name = "lblTradeName";
            this.lblTradeName.Size = new System.Drawing.Size(50, 19);
            this.lblTradeName.TabIndex = 14;
            this.lblTradeName.Text = "Trade";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picPhoto);
            this.panel1.Location = new System.Drawing.Point(525, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 266);
            this.panel1.TabIndex = 15;
            // 
            // picPhoto
            // 
            this.picPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPhoto.Location = new System.Drawing.Point(0, 0);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(241, 266);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // txtWorkerNumber
            // 
            this.txtWorkerNumber.Location = new System.Drawing.Point(140, 113);
            this.txtWorkerNumber.Name = "txtWorkerNumber";
            this.txtWorkerNumber.Size = new System.Drawing.Size(182, 27);
            this.txtWorkerNumber.TabIndex = 16;
            // 
            // btnFetchLabour
            // 
            this.btnFetchLabour.AccessibleName = "Button";
            this.btnFetchLabour.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnFetchLabour.Location = new System.Drawing.Point(343, 112);
            this.btnFetchLabour.Name = "btnFetchLabour";
            this.btnFetchLabour.Size = new System.Drawing.Size(107, 28);
            this.btnFetchLabour.TabIndex = 17;
            this.btnFetchLabour.Text = "Fetch Labour";
            this.btnFetchLabour.Click += new System.EventHandler(this.btnFetchLabour_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(5, 162);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(281, 20);
            this.lblInstruction.TabIndex = 18;
            this.lblInstruction.Text = "Enter full Worker Number like VCE/ ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(616, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(113, 57);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.Visible = false;
            // 
            // lblPhotoFileName
            // 
            this.lblPhotoFileName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoFileName.Location = new System.Drawing.Point(525, 324);
            this.lblPhotoFileName.Name = "lblPhotoFileName";
            this.lblPhotoFileName.Size = new System.Drawing.Size(119, 19);
            this.lblPhotoFileName.TabIndex = 20;
            this.lblPhotoFileName.Text = "PhotoFileName";
            // 
            // frmAssignAccessCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.lblPhotoFileName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnFetchLabour);
            this.Controls.Add(this.txtWorkerNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTradeName);
            this.Controls.Add(this.lblTrade);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblWorkerID);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.btnFetchCard);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAssignAccessCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Card";
            this.Load += new System.EventHandler(this.frmUnAssignAccessCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNumber)).EndInit();
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
        private Syncfusion.WinForms.Controls.SfButton btnFetchCard;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblWorkerName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblWorker;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblWorkerID;
        private Syncfusion.WinForms.Controls.SfButton btnConfirm;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTrade;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTradeName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.TextBox txtWorkerNumber;
        private Syncfusion.WinForms.Controls.SfButton btnFetchLabour;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblInstruction;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblPhotoFileName;
    }
}