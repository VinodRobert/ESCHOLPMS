namespace ESCHOLPMS 
{
    partial class frmTransferOutLabour
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
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel13 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel16 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel17 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbSubContractor = new Syncfusion.WinForms.ListView.SfComboBox();
            this.openFilePhoto = new System.Windows.Forms.OpenFileDialog();
            this.autoLabel18 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.cmbJobType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbLabourType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtRollNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cmbAccessCards = new Syncfusion.WinForms.ListView.SfComboBox();
            this.autoLabel19 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnTerminate = new Syncfusion.WinForms.Controls.SfButton();
            this.btnTransferOut = new Syncfusion.WinForms.Controls.SfButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPhotoFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubContractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJobType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLabourType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRollNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccessCards)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.Location = new System.Drawing.Point(11, 9);
            this.autoLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(111, 19);
            this.autoLabel2.TabIndex = 1;
            this.autoLabel2.Text = "Roll Number ";
            // 
            // txtName
            // 
            this.txtName.BeforeTouchSize = new System.Drawing.Size(377, 29);
            this.txtName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(178, 46);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(422, 29);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "textBoxExt2";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.Location = new System.Drawing.Point(11, 98);
            this.autoLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(34, 19);
            this.autoLabel3.TabIndex = 4;
            this.autoLabel3.Text = "     ";
            // 
            // autoLabel13
            // 
            this.autoLabel13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel13.Location = new System.Drawing.Point(11, 54);
            this.autoLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel13.Name = "autoLabel13";
            this.autoLabel13.Size = new System.Drawing.Size(53, 19);
            this.autoLabel13.TabIndex = 22;
            this.autoLabel13.Text = "Name";
            // 
            // autoLabel16
            // 
            this.autoLabel16.Location = new System.Drawing.Point(623, 9);
            this.autoLabel16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel16.Name = "autoLabel16";
            this.autoLabel16.Size = new System.Drawing.Size(107, 19);
            this.autoLabel16.TabIndex = 30;
            this.autoLabel16.Text = "Labour Type";
            // 
            // autoLabel17
            // 
            this.autoLabel17.Location = new System.Drawing.Point(623, 65);
            this.autoLabel17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel17.Name = "autoLabel17";
            this.autoLabel17.Size = new System.Drawing.Size(131, 19);
            this.autoLabel17.TabIndex = 33;
            this.autoLabel17.Text = "Sub Contractor";
            // 
            // cmbSubContractor
            // 
            this.cmbSubContractor.DisplayMember = "CONTRACTORNAME";
            this.cmbSubContractor.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbSubContractor.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cmbSubContractor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubContractor.Location = new System.Drawing.Point(758, 54);
            this.cmbSubContractor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbSubContractor.Name = "cmbSubContractor";
            this.cmbSubContractor.Size = new System.Drawing.Size(267, 30);
            this.cmbSubContractor.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbSubContractor.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubContractor.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubContractor.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSubContractor.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubContractor.TabIndex = 16;
            this.cmbSubContractor.ValueMember = "CONTRACTORCODE";
            // 
            // openFilePhoto
            // 
            this.openFilePhoto.FileName = "Photo";
            // 
            // autoLabel18
            // 
            this.autoLabel18.Location = new System.Drawing.Point(623, 120);
            this.autoLabel18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel18.Name = "autoLabel18";
            this.autoLabel18.Size = new System.Drawing.Size(85, 19);
            this.autoLabel18.TabIndex = 35;
            this.autoLabel18.Text = "Job  Type";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Location = new System.Drawing.Point(11, 162);
            this.autoLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(56, 19);
            this.autoLabel1.TabIndex = 37;
            this.autoLabel1.Text = "Photo";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(623, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(201, 42);
            this.btnClose.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbJobType
            // 
            this.cmbJobType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbJobType.DisplayMember = "JOBTYPE";
            this.cmbJobType.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbJobType.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cmbJobType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJobType.Location = new System.Drawing.Point(758, 109);
            this.cmbJobType.Name = "cmbJobType";
            this.cmbJobType.Size = new System.Drawing.Size(263, 30);
            this.cmbJobType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbJobType.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJobType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJobType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbJobType.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJobType.TabIndex = 17;
            this.cmbJobType.ValueMember = "JOBTYPE";
            // 
            // cmbLabourType
            // 
            this.cmbLabourType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLabourType.DisplayMember = "LABOURTYPE";
            this.cmbLabourType.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbLabourType.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cmbLabourType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLabourType.Location = new System.Drawing.Point(758, 9);
            this.cmbLabourType.Name = "cmbLabourType";
            this.cmbLabourType.Size = new System.Drawing.Size(263, 30);
            this.cmbLabourType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbLabourType.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLabourType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLabourType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLabourType.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLabourType.TabIndex = 15;
            this.cmbLabourType.ValueMember = "LABOURTYPE";
            // 
            // txtRollNumber
            // 
            this.txtRollNumber.BeforeTouchSize = new System.Drawing.Size(377, 29);
            this.txtRollNumber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollNumber.Location = new System.Drawing.Point(176, 9);
            this.txtRollNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(130, 29);
            this.txtRollNumber.TabIndex = 54;
            this.txtRollNumber.Text = "textBoxExt2";
            // 
            // cmbAccessCards
            // 
            this.cmbAccessCards.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccessCards.DisplayMember = "CARDNUMBER";
            this.cmbAccessCards.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbAccessCards.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cmbAccessCards.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessCards.Location = new System.Drawing.Point(178, 100);
            this.cmbAccessCards.Name = "cmbAccessCards";
            this.cmbAccessCards.Size = new System.Drawing.Size(151, 28);
            this.cmbAccessCards.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbAccessCards.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessCards.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessCards.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbAccessCards.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessCards.TabIndex = 13;
            this.cmbAccessCards.ValueMember = "CARDNUMBER";
            // 
            // autoLabel19
            // 
            this.autoLabel19.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel19.Location = new System.Drawing.Point(8, 109);
            this.autoLabel19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel19.Name = "autoLabel19";
            this.autoLabel19.Size = new System.Drawing.Size(143, 19);
            this.autoLabel19.TabIndex = 55;
            this.autoLabel19.Text = "Access Control #";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(157, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = " ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picPhoto);
            this.panel1.Location = new System.Drawing.Point(178, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 261);
            this.panel1.TabIndex = 71;
            // 
            // picPhoto
            // 
            this.picPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPhoto.Location = new System.Drawing.Point(0, 0);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(266, 259);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 39;
            this.picPhoto.TabStop = false;
            // 
            // btnTerminate
            // 
            this.btnTerminate.AccessibleName = "Button";
            this.btnTerminate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTerminate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnTerminate.Location = new System.Drawing.Point(623, 188);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(201, 40);
            this.btnTerminate.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTerminate.TabIndex = 72;
            this.btnTerminate.Text = "Terminate";
            this.btnTerminate.UseVisualStyleBackColor = false;
            // 
            // btnTransferOut
            // 
            this.btnTransferOut.AccessibleName = "Button";
            this.btnTransferOut.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTransferOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnTransferOut.Location = new System.Drawing.Point(623, 280);
            this.btnTransferOut.Name = "btnTransferOut";
            this.btnTransferOut.Size = new System.Drawing.Size(201, 41);
            this.btnTransferOut.Style.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTransferOut.TabIndex = 73;
            this.btnTransferOut.Text = "Transfer Out";
            this.btnTransferOut.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(944, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(66, 40);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.Visible = false;
            // 
            // lblPhotoFileName
            // 
            this.lblPhotoFileName.AutoSize = true;
            this.lblPhotoFileName.Location = new System.Drawing.Point(179, 430);
            this.lblPhotoFileName.Name = "lblPhotoFileName";
            this.lblPhotoFileName.Size = new System.Drawing.Size(54, 19);
            this.lblPhotoFileName.TabIndex = 75;
            this.lblPhotoFileName.Text = "label1";
            this.lblPhotoFileName.Visible = false;
            // 
            // frmTransferOutLabour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1047, 445);
            this.Controls.Add(this.lblPhotoFileName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTransferOut);
            this.Controls.Add(this.btnTerminate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAccessCards);
            this.Controls.Add(this.autoLabel19);
            this.Controls.Add(this.txtRollNumber);
            this.Controls.Add(this.cmbLabourType);
            this.Controls.Add(this.cmbJobType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.autoLabel18);
            this.Controls.Add(this.cmbSubContractor);
            this.Controls.Add(this.autoLabel17);
            this.Controls.Add(this.autoLabel16);
            this.Controls.Add(this.autoLabel13);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.autoLabel2);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTransferOutLabour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Out";
            this.Load += new System.EventHandler(this.frmNewLabour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubContractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJobType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLabourType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRollNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccessCards)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel13;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel16;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel17;
        private Syncfusion.WinForms.ListView.SfComboBox cmbSubContractor;
        private System.Windows.Forms.OpenFileDialog openFilePhoto;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel18;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.ListView.SfComboBox cmbJobType;
        private Syncfusion.WinForms.ListView.SfComboBox cmbLabourType;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtRollNumber;
        private Syncfusion.WinForms.ListView.SfComboBox cmbAccessCards;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel19;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPhoto;
        private Syncfusion.WinForms.Controls.SfButton btnTerminate;
        private Syncfusion.WinForms.Controls.SfButton btnTransferOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPhotoFileName;
    }
}