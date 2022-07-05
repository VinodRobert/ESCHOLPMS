namespace ESCHOLPMS
{
    partial class frmListSubContractor_Workers
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn2 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.lblHeader = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gridLabours = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExport = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridLabours)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Red;
            this.lblHeader.Location = new System.Drawing.Point(380, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(448, 22);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Complete List of Sub Contractors - Workers";
            // 
            // gridLabours
            // 
            this.gridLabours.AccessibleName = "Table";
            this.gridLabours.AllowEditing = false;
            this.gridLabours.AllowFiltering = true;
            this.gridLabours.AllowTriStateSorting = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "Project";
            gridTextColumn1.MappingName = "ProjectName";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 260D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "LABOURID";
            gridTextColumn2.MappingName = "LabourID";
            gridTextColumn2.Visible = false;
            gridTextColumn2.Width = 56D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Contractor";
            gridTextColumn3.MappingName = "SubContractorName";
            gridTextColumn3.Width = 200D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Number";
            gridTextColumn4.MappingName = "LabourRollNo";
            gridTextColumn4.Width = 120D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "Name";
            gridTextColumn5.MappingName = "LabourName";
            gridTextColumn5.Width = 250D;
            gridDateTimeColumn1.AllowEditing = false;
            gridDateTimeColumn1.AllowFiltering = true;
            gridDateTimeColumn1.HeaderText = "Column10";
            gridDateTimeColumn1.MappingName = "DateOfJoining";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Visible = false;
            gridDateTimeColumn1.Width = 120D;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "Labour Type";
            gridTextColumn6.MappingName = "TypeOfLabour";
            gridTextColumn6.Width = 150D;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.HeaderText = "Skill";
            gridTextColumn7.MappingName = "SkillType";
            gridTextColumn7.Width = 150D;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.AllowFiltering = true;
            gridTextColumn8.HeaderText = "Status";
            gridTextColumn8.MappingName = "Status";
            gridTextColumn8.Width = 220D;
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.AllowFiltering = true;
            gridTextColumn9.HeaderText = "Due";
            gridTextColumn9.MappingName = "Due";
            gridTextColumn9.Visible = false;
            gridTextColumn9.Width = 0D;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.AllowFiltering = true;
            gridTextColumn10.HeaderText = "Mobile #";
            gridTextColumn10.MappingName = "MobileNumber";
            gridTextColumn10.Visible = false;
            gridTextColumn10.Width = 0D;
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.AllowFiltering = true;
            gridTextColumn11.HeaderText = "AccessCardNumber";
            gridTextColumn11.MappingName = "AccessCardNumber";
            gridTextColumn11.Visible = false;
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.AllowFiltering = true;
            gridTextColumn12.HeaderText = "Column13";
            gridTextColumn12.MappingName = "CheckInCount";
            gridTextColumn12.Visible = false;
            gridTextColumn13.AllowEditing = false;
            gridTextColumn13.AllowFiltering = true;
            gridTextColumn13.HeaderText = "Column14";
            gridTextColumn13.MappingName = "SpintlyID";
            gridTextColumn13.Visible = false;
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.AllowFiltering = true;
            gridTextColumn14.HeaderText = "Column15";
            gridTextColumn14.MappingName = "CheckInCount";
            gridTextColumn14.Visible = false;
            gridDateTimeColumn2.AllowEditing = false;
            gridDateTimeColumn2.AllowFiltering = true;
            gridDateTimeColumn2.HeaderText = "Column16";
            gridDateTimeColumn2.MappingName = "LastCheckInDate";
            gridDateTimeColumn2.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn2.Visible = false;
            gridTextColumn15.AllowEditing = false;
            gridTextColumn15.AllowFiltering = true;
            gridTextColumn15.HeaderText = "Column17";
            gridTextColumn15.MappingName = "LastCheckIn";
            gridTextColumn15.Visible = false;
            this.gridLabours.Columns.Add(gridTextColumn1);
            this.gridLabours.Columns.Add(gridTextColumn2);
            this.gridLabours.Columns.Add(gridTextColumn3);
            this.gridLabours.Columns.Add(gridTextColumn4);
            this.gridLabours.Columns.Add(gridTextColumn5);
            this.gridLabours.Columns.Add(gridDateTimeColumn1);
            this.gridLabours.Columns.Add(gridTextColumn6);
            this.gridLabours.Columns.Add(gridTextColumn7);
            this.gridLabours.Columns.Add(gridTextColumn8);
            this.gridLabours.Columns.Add(gridTextColumn9);
            this.gridLabours.Columns.Add(gridTextColumn10);
            this.gridLabours.Columns.Add(gridTextColumn11);
            this.gridLabours.Columns.Add(gridTextColumn12);
            this.gridLabours.Columns.Add(gridTextColumn13);
            this.gridLabours.Columns.Add(gridTextColumn14);
            this.gridLabours.Columns.Add(gridDateTimeColumn2);
            this.gridLabours.Columns.Add(gridTextColumn15);
            this.gridLabours.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLabours.Location = new System.Drawing.Point(11, 43);
            this.gridLabours.Margin = new System.Windows.Forms.Padding(2);
            this.gridLabours.Name = "gridLabours";
            this.gridLabours.PreviewRowHeight = 35;
            this.gridLabours.Size = new System.Drawing.Size(1202, 492);
            this.gridLabours.TabIndex = 1;
            this.gridLabours.Text = "sfDataGrid1";
           
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.BackColor = System.Drawing.Color.Fuchsia;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(1114, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 28);
            this.btnClose.Style.BackColor = System.Drawing.Color.Fuchsia;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExport
            // 
            this.btnExport.AccessibleName = "Button";
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(976, 11);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(134, 28);
            this.btnExport.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExport.Style.ForeColor = System.Drawing.Color.White;
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmListSubContractor_Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 546);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridLabours);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListSubContractor_Workers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contractors = Workers List";
            this.Load += new System.EventHandler(this.frmLabourLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLabours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblHeader;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridLabours;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.Controls.SfButton btnExport;
    }
}