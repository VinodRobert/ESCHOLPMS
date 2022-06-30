namespace ESCHOLPMS 
{
    partial class frmLabourAttendance
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn3 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn4 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtAttendance = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.btnFetch = new Syncfusion.WinForms.Controls.SfButton();
            this.gridAttendance = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnExport = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDetail = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Labour Attendance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Attendance Of ";
            // 
            // dtAttendance
            // 
            this.dtAttendance.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate;
            this.dtAttendance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAttendance.Location = new System.Drawing.Point(169, 55);
            this.dtAttendance.Name = "dtAttendance";
            this.dtAttendance.Size = new System.Drawing.Size(306, 34);
            this.dtAttendance.TabIndex = 2;
            // 
            // btnFetch
            // 
            this.btnFetch.AccessibleName = "Button";
            this.btnFetch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnFetch.Location = new System.Drawing.Point(494, 61);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(96, 28);
            this.btnFetch.TabIndex = 3;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // gridAttendance
            // 
            this.gridAttendance.AccessibleName = "Table";
            this.gridAttendance.AllowFiltering = true;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "LabourID";
            gridTextColumn1.MappingName = "LABOURID";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 0D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Worker Roll No";
            gridTextColumn2.MappingName = "LABOURROLLNO";
            gridTextColumn2.Width = 100D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Worker Name";
            gridTextColumn3.MappingName = "LABOURNAME";
            gridTextColumn3.Width = 145D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Check In";
            gridTextColumn4.MappingName = "INTIME";
            gridTextColumn4.Width = 90D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "Check Out";
            gridTextColumn5.MappingName = "OUTTIME";
            gridTextColumn5.Width = 90D;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "Working Time";
            gridTextColumn6.MappingName = "WORKINGTIME";
            gridTextColumn6.Width = 95D;
            gridNumericColumn1.AllowEditing = false;
            gridNumericColumn1.AllowFiltering = true;
            gridNumericColumn1.HeaderText = "Attendance";
            gridNumericColumn1.MappingName = "WORKINGDAY";
            gridNumericColumn1.Width = 80D;
            gridNumericColumn2.AllowEditing = false;
            gridNumericColumn2.AllowFiltering = true;
            gridNumericColumn2.HeaderText = "OT (Hours)";
            gridNumericColumn2.MappingName = "OTHOURS";
            gridNumericColumn2.Width = 75D;
            gridNumericColumn3.AllowFiltering = true;
            gridNumericColumn3.CellStyle.Font.Bold = true;
            gridNumericColumn3.CellStyle.Font.Facename = "Arial";
            gridNumericColumn3.CellStyle.Font.Size = 9F;
            gridNumericColumn3.CellStyle.TextColor = System.Drawing.Color.Red;
            gridNumericColumn3.HeaderText = "DAY";
            gridNumericColumn3.MappingName = "DAYEDITED";
            gridNumericColumn3.Width = 80D;
            gridNumericColumn4.AllowFiltering = true;
            gridNumericColumn4.CellStyle.Font.Bold = true;
            gridNumericColumn4.CellStyle.Font.Facename = "Arial";
            gridNumericColumn4.CellStyle.Font.Size = 9F;
            gridNumericColumn4.CellStyle.TextColor = System.Drawing.Color.Blue;
            gridNumericColumn4.HeaderText = "OT (Hrs)";
            gridNumericColumn4.MappingName = "OTEDITED";
            gridNumericColumn4.Width = 80D;
            this.gridAttendance.Columns.Add(gridTextColumn1);
            this.gridAttendance.Columns.Add(gridTextColumn2);
            this.gridAttendance.Columns.Add(gridTextColumn3);
            this.gridAttendance.Columns.Add(gridTextColumn4);
            this.gridAttendance.Columns.Add(gridTextColumn5);
            this.gridAttendance.Columns.Add(gridTextColumn6);
            this.gridAttendance.Columns.Add(gridNumericColumn1);
            this.gridAttendance.Columns.Add(gridNumericColumn2);
            this.gridAttendance.Columns.Add(gridNumericColumn3);
            this.gridAttendance.Columns.Add(gridNumericColumn4);
            this.gridAttendance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAttendance.Location = new System.Drawing.Point(12, 113);
            this.gridAttendance.Name = "gridAttendance";
            this.gridAttendance.PreviewRowHeight = 35;
            this.gridAttendance.Size = new System.Drawing.Size(1129, 622);
            this.gridAttendance.TabIndex = 4;
            this.gridAttendance.Text = "sfDataGrid1";
            // 
            // btnExport
            // 
            this.btnExport.AccessibleName = "Button";
            this.btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExport.Location = new System.Drawing.Point(673, 61);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(96, 28);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Summary ";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.AccessibleName = "Button";
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnDetail.Location = new System.Drawing.Point(846, 61);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(96, 28);
            this.btnDetail.TabIndex = 6;
            this.btnDetail.Text = "Detail";
            // 
            // frmLabourAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 747);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gridAttendance);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.dtAttendance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLabourAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labour Attendance";
            this.Load += new System.EventHandler(this.frmLabourAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtAttendance;
        private Syncfusion.WinForms.Controls.SfButton btnFetch;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridAttendance;
        private Syncfusion.WinForms.Controls.SfButton btnExport;
        private Syncfusion.WinForms.Controls.SfButton btnDetail;
    }
}