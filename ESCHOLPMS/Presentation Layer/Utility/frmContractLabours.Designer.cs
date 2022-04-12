namespace ESCHOLPMS 
{
    partial class frmContractLabours
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
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn2 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn3 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gridList = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnExcel = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(553, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contractors - Labours";
            // 
            // gridList
            // 
            this.gridList.AccessibleName = "Table";
            this.gridList.AllowFiltering = true;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "LABOURID";
            gridTextColumn1.MappingName = "LABOURID";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 0D;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Project Name";
            gridTextColumn2.MappingName = "PROJECTNAME";
            gridTextColumn2.Width = 200D;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Sub Contractor ";
            gridTextColumn3.MappingName = "SUBCONTRACTORNAME";
            gridTextColumn3.Width = 250D;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Labour Roll #";
            gridTextColumn4.MappingName = "LABOURROLLNO";
            gridTextColumn4.Width = 120D;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "Labour Name";
            gridTextColumn5.MappingName = "LABOURNAME";
            gridTextColumn5.Width = 250D;
            gridDateTimeColumn1.AllowFiltering = true;
            gridDateTimeColumn1.HeaderText = "Birth Day";
            gridDateTimeColumn1.MappingName = "DATEOFBIRTH";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Width = 90D;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "State";
            gridTextColumn6.MappingName = "STATE";
            gridTextColumn6.Width = 150D;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.HeaderText = "Mobile #";
            gridTextColumn7.MappingName = "MOBILENUMBER";
            gridTextColumn7.Width = 120D;
            gridDateTimeColumn2.AllowFiltering = true;
            gridDateTimeColumn2.HeaderText = "Join Date";
            gridDateTimeColumn2.MappingName = "DATEOFJOINING";
            gridDateTimeColumn2.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn2.Width = 120D;
            gridTextColumn8.AllowFiltering = true;
            gridTextColumn8.HeaderText = "Skill Type";
            gridTextColumn8.MappingName = "SKILLTYPE";
            gridTextColumn8.Width = 150D;
            gridTextColumn9.AllowFiltering = true;
            gridTextColumn9.HeaderText = "Status";
            gridTextColumn9.MappingName = "STATUS";
            gridTextColumn9.Width = 150D;
            gridDateTimeColumn3.AllowFiltering = true;
            gridDateTimeColumn3.HeaderText = "Last Updated";
            gridDateTimeColumn3.MappingName = "LASTUPDATETIME";
            gridDateTimeColumn3.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn3.Width = 120D;
            this.gridList.Columns.Add(gridTextColumn1);
            this.gridList.Columns.Add(gridTextColumn2);
            this.gridList.Columns.Add(gridTextColumn3);
            this.gridList.Columns.Add(gridTextColumn4);
            this.gridList.Columns.Add(gridTextColumn5);
            this.gridList.Columns.Add(gridDateTimeColumn1);
            this.gridList.Columns.Add(gridTextColumn6);
            this.gridList.Columns.Add(gridTextColumn7);
            this.gridList.Columns.Add(gridDateTimeColumn2);
            this.gridList.Columns.Add(gridTextColumn8);
            this.gridList.Columns.Add(gridTextColumn9);
            this.gridList.Columns.Add(gridDateTimeColumn3);
            this.gridList.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Top;
            this.gridList.FrozenColumnCount = 5;
            this.gridList.Location = new System.Drawing.Point(12, 84);
            this.gridList.Name = "gridList";
            this.gridList.PreviewRowHeight = 35;
            this.gridList.RowHeight = 25;
            this.gridList.ShowGroupDropArea = true;
            this.gridList.Size = new System.Drawing.Size(1361, 578);
            this.gridList.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridList.Style.HeaderStyle.Font.Bold = true;
            this.gridList.Style.HeaderStyle.Font.Facename = "Arial";
            this.gridList.Style.HeaderStyle.TextColor = System.Drawing.Color.White;
            this.gridList.TabIndex = 1;
            this.gridList.Text = "sfDataGrid1";
            this.gridList.DrawCell += new Syncfusion.WinForms.DataGrid.Events.DrawCellEventHandler(this.gridList_DrawCell);
            this.gridList.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridList_QueryRowStyle);
            // 
            // btnExcel
            // 
            this.btnExcel.AccessibleName = "Button";
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnExcel.ForeColor = System.Drawing.Color.Blue;
            this.btnExcel.Location = new System.Drawing.Point(1135, 50);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(96, 28);
            this.btnExcel.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Excel";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1277, 50);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Red;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmContractLabours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 686);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.gridList);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmContractLabours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contractors - Labours";
            this.Load += new System.EventHandler(this.frmContractLabours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridList;
        private Syncfusion.WinForms.Controls.SfButton btnExcel;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}