namespace ESCHOLPMS 
{
    partial class frmTerminateList
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
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
            this.autoLabel1.Location = new System.Drawing.Point(363, 9);
            this.autoLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(494, 23);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "List Of Labours - For Permanent Termination";
            // 
            // gridLabours
            // 
            this.gridLabours.AccessibleName = "Table";
            this.gridLabours.AllowEditing = false;
            this.gridLabours.AllowFiltering = true;
            this.gridLabours.AllowTriStateSorting = true;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "LABOURID";
            gridTextColumn1.MappingName = "LabourID";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 56D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "PROJECTNAME";
            gridTextColumn2.MappingName = "ProjectName";
            gridTextColumn2.Visible = false;
            gridTextColumn2.Width = 0D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Number";
            gridTextColumn3.MappingName = "LabourRollNo";
            gridTextColumn3.Width = 130D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Name";
            gridTextColumn4.MappingName = "LabourName";
            gridTextColumn4.Width = 215D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "Mobile #";
            gridTextColumn5.MappingName = "MobileNumber";
            gridTextColumn5.Width = 120D;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "Labour Type";
            gridTextColumn6.MappingName = "TypeOfLabour";
            gridTextColumn6.Width = 150D;
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.HeaderText = "Skill";
            gridTextColumn7.MappingName = "SkillType";
            gridTextColumn7.Width = 130D;
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.AllowFiltering = true;
            gridTextColumn8.HeaderText = "Contractor";
            gridTextColumn8.MappingName = "SubContractorName";
            gridTextColumn8.Width = 180D;
            gridTextColumn9.AllowEditing = false;
            gridTextColumn9.AllowFiltering = true;
            gridTextColumn9.HeaderText = "Status";
            gridTextColumn9.MappingName = "Status";
            gridTextColumn9.Width = 220D;
            gridDateTimeColumn1.AllowEditing = false;
            gridDateTimeColumn1.AllowFiltering = true;
            gridDateTimeColumn1.HeaderText = "Column10";
            gridDateTimeColumn1.MappingName = "DateOfJoining";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Visible = false;
            gridDateTimeColumn1.Width = 0D;
            gridTextColumn10.AllowEditing = false;
            gridTextColumn10.AllowFiltering = true;
            gridTextColumn10.HeaderText = "Due";
            gridTextColumn10.MappingName = "Due";
            gridTextColumn10.Visible = false;
            gridTextColumn10.Width = 0D;
            this.gridLabours.Columns.Add(gridTextColumn1);
            this.gridLabours.Columns.Add(gridTextColumn2);
            this.gridLabours.Columns.Add(gridTextColumn3);
            this.gridLabours.Columns.Add(gridTextColumn4);
            this.gridLabours.Columns.Add(gridTextColumn5);
            this.gridLabours.Columns.Add(gridTextColumn6);
            this.gridLabours.Columns.Add(gridTextColumn7);
            this.gridLabours.Columns.Add(gridTextColumn8);
            this.gridLabours.Columns.Add(gridTextColumn9);
            this.gridLabours.Columns.Add(gridDateTimeColumn1);
            this.gridLabours.Columns.Add(gridTextColumn10);
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
            // frmTerminateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 546);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridLabours);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTerminateList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labour Lists";
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