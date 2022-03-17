namespace ESCHOLPMS 
{
    partial class frmLabourListsCertificate
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn11 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn16 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn2 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn17 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn18 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gridLabours = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridLabours)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel1.Location = new System.Drawing.Point(359, 28);
            this.autoLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(414, 23);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "List Of Labours For Certificate Upload";
            // 
            // gridLabours
            // 
            this.gridLabours.AccessibleName = "Table";
            this.gridLabours.AllowEditing = false;
            this.gridLabours.AllowFiltering = true;
            this.gridLabours.AllowTriStateSorting = true;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.AllowFiltering = true;
            gridTextColumn10.HeaderText = "LABOURID";
            gridTextColumn10.MappingName = "LabourID";
            gridTextColumn10.Visible = false;
            gridTextColumn10.Width = 56D;
            gridTextColumn11.AllowEditing = false;
            gridTextColumn11.AllowFiltering = true;
            gridTextColumn11.HeaderText = "PROJECTNAME";
            gridTextColumn11.MappingName = "ProjectName";
            gridTextColumn11.Visible = false;
            gridTextColumn11.Width = 0D;
            gridTextColumn12.AllowEditing = false;
            gridTextColumn12.AllowFiltering = true;
            gridTextColumn12.HeaderText = "Number";
            gridTextColumn12.MappingName = "LabourRollNo";
            gridTextColumn12.Width = 130D;
            gridTextColumn13.AllowEditing = false;
            gridTextColumn13.AllowFiltering = true;
            gridTextColumn13.HeaderText = "Name";
            gridTextColumn13.MappingName = "LabourName";
            gridTextColumn13.Width = 245D;
            gridTextColumn14.AllowEditing = false;
            gridTextColumn14.AllowFiltering = true;
            gridTextColumn14.HeaderText = "Labour Type";
            gridTextColumn14.MappingName = "TypeOfLabour";
            gridTextColumn14.Width = 140D;
            gridTextColumn15.AllowEditing = false;
            gridTextColumn15.AllowFiltering = true;
            gridTextColumn15.HeaderText = "Skill";
            gridTextColumn15.MappingName = "SkillType";
            gridTextColumn15.Width = 110D;
            gridTextColumn16.AllowEditing = false;
            gridTextColumn16.AllowFiltering = true;
            gridTextColumn16.HeaderText = "Contractor";
            gridTextColumn16.MappingName = "SubContractorName";
            gridTextColumn16.Width = 180D;
            gridDateTimeColumn2.AllowEditing = false;
            gridDateTimeColumn2.AllowFiltering = true;
            gridDateTimeColumn2.HeaderText = "Joining Date";
            gridDateTimeColumn2.MappingName = "DateOfJoining";
            gridDateTimeColumn2.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridTextColumn17.AllowEditing = false;
            gridTextColumn17.AllowFiltering = true;
            gridTextColumn17.HeaderText = "Status";
            gridTextColumn17.MappingName = "Status";
            gridTextColumn17.Width = 210D;
            gridTextColumn18.AllowEditing = false;
            gridTextColumn18.AllowFiltering = true;
            gridTextColumn18.HeaderText = "Column10";
            gridTextColumn18.MappingName = "MobileNumber";
            gridTextColumn18.Visible = false;
            this.gridLabours.Columns.Add(gridTextColumn10);
            this.gridLabours.Columns.Add(gridTextColumn11);
            this.gridLabours.Columns.Add(gridTextColumn12);
            this.gridLabours.Columns.Add(gridTextColumn13);
            this.gridLabours.Columns.Add(gridTextColumn14);
            this.gridLabours.Columns.Add(gridTextColumn15);
            this.gridLabours.Columns.Add(gridTextColumn16);
            this.gridLabours.Columns.Add(gridDateTimeColumn2);
            this.gridLabours.Columns.Add(gridTextColumn17);
            this.gridLabours.Columns.Add(gridTextColumn18);
            this.gridLabours.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLabours.Location = new System.Drawing.Point(11, 67);
            this.gridLabours.Margin = new System.Windows.Forms.Padding(2);
            this.gridLabours.Name = "gridLabours";
            this.gridLabours.PreviewRowHeight = 35;
            this.gridLabours.Size = new System.Drawing.Size(1177, 468);
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
            this.btnClose.Location = new System.Drawing.Point(1116, 28);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 28);
            this.btnClose.Style.BackColor = System.Drawing.Color.Fuchsia;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLabourListsCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 546);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridLabours);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLabourListsCertificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labour Lists | Upload Certificates";
            this.Load += new System.EventHandler(this.frmLabourLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLabours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridLabours;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}