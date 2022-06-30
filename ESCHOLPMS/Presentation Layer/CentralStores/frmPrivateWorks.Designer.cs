namespace ESCHOLPMS 
{
    partial class frmPrivateWorks
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn2 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            this.gridResult = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblHeader = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dtEndDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtStartDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.txtLocation = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtWorkFullName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPrivateWorks = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnSave = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrivateWorks)).BeginInit();
            this.SuspendLayout();
            // 
            // gridResult
            // 
            this.gridResult.AccessibleName = "Table";
            gridTextColumn1.HeaderText = "Column1";
            gridTextColumn1.MappingName = "PRIVATEWORKID";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 0D;
            gridTextColumn2.HeaderText = "Short Name";
            gridTextColumn2.MappingName = "WORKSHORTNAME";
            gridTextColumn2.Width = 200D;
            gridTextColumn3.HeaderText = "Work Name";
            gridTextColumn3.MappingName = "WORKNAME";
            gridTextColumn3.Width = 350D;
            gridTextColumn4.HeaderText = "Location ";
            gridTextColumn4.MappingName = "LOCATION";
            gridTextColumn4.Width = 200D;
            gridDateTimeColumn1.HeaderText = "Start Date";
            gridDateTimeColumn1.MappingName = "STARTDATE";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Width = 130D;
            gridDateTimeColumn2.HeaderText = "End Date";
            gridDateTimeColumn2.MappingName = "ENDDATE";
            gridDateTimeColumn2.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn2.Width = 130D;
            this.gridResult.Columns.Add(gridTextColumn1);
            this.gridResult.Columns.Add(gridTextColumn2);
            this.gridResult.Columns.Add(gridTextColumn3);
            this.gridResult.Columns.Add(gridTextColumn4);
            this.gridResult.Columns.Add(gridDateTimeColumn1);
            this.gridResult.Columns.Add(gridDateTimeColumn2);
            this.gridResult.Location = new System.Drawing.Point(13, 184);
            this.gridResult.Name = "gridResult";
            this.gridResult.PreviewRowHeight = 35;
            this.gridResult.Size = new System.Drawing.Size(1016, 347);
            this.gridResult.TabIndex = 0;
            this.gridResult.Text = "sfDataGrid1";
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Blue;
            this.lblHeader.Location = new System.Drawing.Point(413, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(242, 27);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "List of Private Works";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Brown;
            this.autoLabel1.Location = new System.Drawing.Point(13, 51);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(216, 19);
            this.autoLabel1.TabIndex = 2;
            this.autoLabel1.Text = "Short Name (15 Characters)";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.Brown;
            this.autoLabel2.Location = new System.Drawing.Point(13, 98);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(96, 19);
            this.autoLabel2.TabIndex = 3;
            this.autoLabel2.Text = "Work Name";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.Brown;
            this.autoLabel3.Location = new System.Drawing.Point(13, 146);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(71, 19);
            this.autoLabel3.TabIndex = 4;
            this.autoLabel3.Text = "Location";
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.Brown;
            this.autoLabel4.Location = new System.Drawing.Point(474, 122);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(82, 19);
            this.autoLabel4.TabIndex = 5;
            this.autoLabel4.Text = "Start Date";
            // 
            // autoLabel5
            // 
            this.autoLabel5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel5.ForeColor = System.Drawing.Color.Brown;
            this.autoLabel5.Location = new System.Drawing.Point(952, 122);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(77, 19);
            this.autoLabel5.TabIndex = 6;
            this.autoLabel5.Text = "End Date";
            // 
            // dtEndDate
            // 
            this.dtEndDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate;
            this.dtEndDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Format = "dd/MM/yyyy";
            this.dtEndDate.Location = new System.Drawing.Point(747, 144);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(282, 34);
            this.dtEndDate.TabIndex = 7;
            // 
            // dtStartDate
            // 
            this.dtStartDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate;
            this.dtStartDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = "dd/MM/yyyy";
            this.dtStartDate.Location = new System.Drawing.Point(474, 144);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(267, 34);
            this.dtStartDate.TabIndex = 8;
            // 
            // txtLocation
            // 
            this.txtLocation.BeforeTouchSize = new System.Drawing.Size(271, 28);
            this.txtLocation.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(128, 146);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(328, 28);
            this.txtLocation.TabIndex = 9;
            this.txtLocation.Text = "textBoxExt1";
            // 
            // txtWorkFullName
            // 
            this.txtWorkFullName.BeforeTouchSize = new System.Drawing.Size(271, 28);
            this.txtWorkFullName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkFullName.Location = new System.Drawing.Point(128, 89);
            this.txtWorkFullName.Name = "txtWorkFullName";
            this.txtWorkFullName.Size = new System.Drawing.Size(901, 28);
            this.txtWorkFullName.TabIndex = 10;
            this.txtWorkFullName.Text = "textBoxExt1";
            // 
            // txtPrivateWorks
            // 
            this.txtPrivateWorks.BeforeTouchSize = new System.Drawing.Size(271, 28);
            this.txtPrivateWorks.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivateWorks.Location = new System.Drawing.Point(252, 51);
            this.txtPrivateWorks.MaxLength = 15;
            this.txtPrivateWorks.Name = "txtPrivateWorks";
            this.txtPrivateWorks.Size = new System.Drawing.Size(271, 28);
            this.txtPrivateWorks.TabIndex = 11;
            this.txtPrivateWorks.Text = "textBoxExt1";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "Button";
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(800, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 28);
            this.btnSave.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "New";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(933, 51);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPrivateWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 543);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrivateWorks);
            this.Controls.Add(this.txtWorkFullName);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.autoLabel5);
            this.Controls.Add(this.autoLabel4);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.gridResult);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrivateWorks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Private Works";
            this.Load += new System.EventHandler(this.frmPrivateWorks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrivateWorks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid gridResult;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblHeader;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtEndDate;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtStartDate;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLocation;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtWorkFullName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPrivateWorks;
        private Syncfusion.WinForms.Controls.SfButton btnSave;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}