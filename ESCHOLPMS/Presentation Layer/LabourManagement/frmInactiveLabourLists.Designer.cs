namespace ESCHOLPMS 
{
    partial class frmInactiveLabourLists
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
            this.autoLabel1.Location = new System.Drawing.Point(529, 9);
            this.autoLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(268, 23);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "List Of Inactive Labours";
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
            gridTextColumn2.HeaderText = "Number";
            gridTextColumn2.MappingName = "LabourRollNo";
            gridTextColumn2.Width = 140D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Name";
            gridTextColumn3.MappingName = "LabourName";
            gridTextColumn3.Width = 250D;
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Skill Type";
            gridTextColumn4.MappingName = "SkillType";
            gridTextColumn4.Width = 150D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "Status";
            gridTextColumn5.MappingName = "Status";
            gridTextColumn5.Width = 160D;
            gridDateTimeColumn1.AllowEditing = false;
            gridDateTimeColumn1.AllowFiltering = true;
            gridDateTimeColumn1.HeaderText = "Date of Exit";
            gridDateTimeColumn1.MappingName = "DateOfExit";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Visible = false;
            gridDateTimeColumn1.Width = 120D;
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "Remarks";
            gridTextColumn6.MappingName = "Remarks";
            gridTextColumn6.Width = 300D;
            this.gridLabours.Columns.Add(gridTextColumn1);
            this.gridLabours.Columns.Add(gridTextColumn2);
            this.gridLabours.Columns.Add(gridTextColumn3);
            this.gridLabours.Columns.Add(gridTextColumn4);
            this.gridLabours.Columns.Add(gridTextColumn5);
            this.gridLabours.Columns.Add(gridDateTimeColumn1);
            this.gridLabours.Columns.Add(gridTextColumn6);
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
            // frmInactiveLabourLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 546);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridLabours);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInactiveLabourLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In Active Labours";
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