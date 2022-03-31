namespace ESCHOLPMS 
{
    partial class frmList_Complete
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn2 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn16 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn17 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn18 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn19 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn20 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.lblHeader = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gridLabours = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExport = new Syncfusion.WinForms.Controls.SfButton();
            this.btnActive = new Syncfusion.WinForms.Controls.SfButton();
            this.btnInactive = new Syncfusion.WinForms.Controls.SfButton();
            this.btnTerminated = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridLabours)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Red;
            this.lblHeader.Location = new System.Drawing.Point(455, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(278, 23);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Complete List of Labours";
            // 
            // gridLabours
            // 
            this.gridLabours.AccessibleName = "Table";
            this.gridLabours.AllowEditing = false;
            this.gridLabours.AllowFiltering = true;
            this.gridLabours.AllowTriStateSorting = true;
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.AllowFiltering = true;
            gridTextColumn11.HeaderText = "LABOURID";
            gridTextColumn11.MappingName = "LabourID";
            gridTextColumn11.Visible = false;
            gridTextColumn11.Width = 56D;
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.AllowFiltering = true;
            gridTextColumn12.HeaderText = "Project";
            gridTextColumn12.MappingName = "ProjectName";
            gridTextColumn12.Width = 260D;
            gridTextColumn13.AllowEditing = false;
            gridTextColumn13.AllowFiltering = true;
            gridTextColumn13.HeaderText = "Number";
            gridTextColumn13.MappingName = "LabourRollNo";
            gridTextColumn13.Width = 110D;
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.AllowFiltering = true;
            gridTextColumn14.HeaderText = "Name";
            gridTextColumn14.MappingName = "LabourName";
            gridTextColumn14.Width = 180D;
            gridDateTimeColumn2.AllowEditing = false;
            gridDateTimeColumn2.AllowFiltering = true;
            gridDateTimeColumn2.HeaderText = "Column10";
            gridDateTimeColumn2.MappingName = "DateOfJoining";
            gridDateTimeColumn2.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn2.Visible = false;
            gridDateTimeColumn2.Width = 120D;
            gridTextColumn15.AllowEditing = false;
            gridTextColumn15.AllowFiltering = true;
            gridTextColumn15.HeaderText = "Labour Type";
            gridTextColumn15.MappingName = "TypeOfLabour";
            gridTextColumn15.Width = 150D;
            gridTextColumn16.AllowEditing = false;
            gridTextColumn16.AllowFiltering = true;
            gridTextColumn16.HeaderText = "Skill";
            gridTextColumn16.MappingName = "SkillType";
            gridTextColumn16.Width = 120D;
            gridTextColumn17.AllowEditing = false;
            gridTextColumn17.AllowFiltering = true;
            gridTextColumn17.HeaderText = "Contractor";
            gridTextColumn17.MappingName = "SubContractorName";
            gridTextColumn17.Width = 160D;
            gridTextColumn18.AllowEditing = false;
            gridTextColumn18.AllowFiltering = true;
            gridTextColumn18.HeaderText = "Status";
            gridTextColumn18.MappingName = "Status";
            gridTextColumn18.Width = 220D;
            gridTextColumn19.AllowEditing = false;
            gridTextColumn19.AllowFiltering = true;
            gridTextColumn19.HeaderText = "Due";
            gridTextColumn19.MappingName = "Due";
            gridTextColumn19.Visible = false;
            gridTextColumn19.Width = 0D;
            gridTextColumn20.AllowEditing = false;
            gridTextColumn20.AllowFiltering = true;
            gridTextColumn20.HeaderText = "Mobile #";
            gridTextColumn20.MappingName = "MobileNumber";
            gridTextColumn20.Visible = false;
            gridTextColumn20.Width = 0D;
            this.gridLabours.Columns.Add(gridTextColumn11);
            this.gridLabours.Columns.Add(gridTextColumn12);
            this.gridLabours.Columns.Add(gridTextColumn13);
            this.gridLabours.Columns.Add(gridTextColumn14);
            this.gridLabours.Columns.Add(gridDateTimeColumn2);
            this.gridLabours.Columns.Add(gridTextColumn15);
            this.gridLabours.Columns.Add(gridTextColumn16);
            this.gridLabours.Columns.Add(gridTextColumn17);
            this.gridLabours.Columns.Add(gridTextColumn18);
            this.gridLabours.Columns.Add(gridTextColumn19);
            this.gridLabours.Columns.Add(gridTextColumn20);
            this.gridLabours.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLabours.Location = new System.Drawing.Point(11, 88);
            this.gridLabours.Margin = new System.Windows.Forms.Padding(2);
            this.gridLabours.Name = "gridLabours";
            this.gridLabours.PreviewRowHeight = 35;
            this.gridLabours.Size = new System.Drawing.Size(1238, 447);
            this.gridLabours.TabIndex = 1;
            this.gridLabours.Text = "sfDataGrid1";
            this.gridLabours.DrawCell += new Syncfusion.WinForms.DataGrid.Events.DrawCellEventHandler(this.gridLabours_DrawCell);
            this.gridLabours.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridLabours_QueryRowStyle);
            this.gridLabours.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.gridLabours_CellDoubleClick);
            this.gridLabours.DoubleClick += new System.EventHandler(this.gridLabours_DoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.BackColor = System.Drawing.Color.Fuchsia;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(1177, 45);
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
            this.btnExport.Location = new System.Drawing.Point(1039, 45);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(134, 28);
            this.btnExport.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExport.Style.ForeColor = System.Drawing.Color.White;
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnActive
            // 
            this.btnActive.AccessibleName = "Button";
            this.btnActive.BackColor = System.Drawing.Color.Blue;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnActive.ForeColor = System.Drawing.Color.White;
            this.btnActive.Location = new System.Drawing.Point(12, 45);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(163, 28);
            this.btnActive.Style.BackColor = System.Drawing.Color.Blue;
            this.btnActive.Style.ForeColor = System.Drawing.Color.White;
            this.btnActive.TabIndex = 7;
            this.btnActive.Text = "Active Labours";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnInactive
            // 
            this.btnInactive.AccessibleName = "Button";
            this.btnInactive.BackColor = System.Drawing.Color.Blue;
            this.btnInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactive.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnInactive.ForeColor = System.Drawing.Color.White;
            this.btnInactive.Location = new System.Drawing.Point(270, 45);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(163, 28);
            this.btnInactive.Style.BackColor = System.Drawing.Color.Blue;
            this.btnInactive.Style.ForeColor = System.Drawing.Color.White;
            this.btnInactive.TabIndex = 8;
            this.btnInactive.Text = "In-Active Labours";
            this.btnInactive.UseVisualStyleBackColor = true;
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
            // 
            // btnTerminated
            // 
            this.btnTerminated.AccessibleName = "Button";
            this.btnTerminated.BackColor = System.Drawing.Color.Blue;
            this.btnTerminated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminated.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnTerminated.ForeColor = System.Drawing.Color.White;
            this.btnTerminated.Location = new System.Drawing.Point(529, 45);
            this.btnTerminated.Name = "btnTerminated";
            this.btnTerminated.Size = new System.Drawing.Size(163, 28);
            this.btnTerminated.Style.BackColor = System.Drawing.Color.Blue;
            this.btnTerminated.Style.ForeColor = System.Drawing.Color.White;
            this.btnTerminated.TabIndex = 9;
            this.btnTerminated.Text = "Terminated Labours";
            this.btnTerminated.UseVisualStyleBackColor = true;
            this.btnTerminated.Click += new System.EventHandler(this.btnTerminated_Click);
            // 
            // frmList_Complete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 546);
            this.Controls.Add(this.btnTerminated);
            this.Controls.Add(this.btnInactive);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridLabours);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmList_Complete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete List of Labours";
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
        private Syncfusion.WinForms.Controls.SfButton btnActive;
        private Syncfusion.WinForms.Controls.SfButton btnInactive;
        private Syncfusion.WinForms.Controls.SfButton btnTerminated;
    }
}