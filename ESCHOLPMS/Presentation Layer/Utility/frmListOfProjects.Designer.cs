namespace ESCHOLPMS 
{
    partial class frmListOfProjects
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn12 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn13 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn14 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn15 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn16 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn17 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn18 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn19 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn20 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn21 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn22 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gridList = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(682, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Projects";
            // 
            // gridList
            // 
            this.gridList.AccessibleName = "Table";
            this.gridList.AllowFiltering = true;
            this.gridList.AllowResizingColumns = true;
            this.gridList.AutoGenerateColumns = false;
            gridTextColumn12.AllowFiltering = true;
            gridTextColumn12.AllowResizing = true;
            gridTextColumn12.HeaderText = "Code";
            gridTextColumn12.MappingName = "CODE";
            gridTextColumn12.Width = 100D;
            gridTextColumn13.AllowFiltering = true;
            gridTextColumn13.AllowResizing = true;
            gridTextColumn13.HeaderText = "Status";
            gridTextColumn13.MappingName = "STATUS";
            gridTextColumn13.Width = 100D;
            gridTextColumn14.AllowFiltering = true;
            gridTextColumn14.AllowResizing = true;
            gridTextColumn14.HeaderText = "ProjectID";
            gridTextColumn14.MappingName = "ID";
            gridTextColumn14.Width = 100D;
            gridTextColumn15.AllowFiltering = true;
            gridTextColumn15.AllowResizing = true;
            gridTextColumn15.HeaderText = "Project Name";
            gridTextColumn15.MappingName = "NAME";
            gridTextColumn15.Width = 300D;
            gridTextColumn16.AllowFiltering = true;
            gridTextColumn16.AllowResizing = true;
            gridTextColumn16.HeaderText = "Short";
            gridTextColumn16.MappingName = "SHORT";
            gridTextColumn16.Width = 120D;
            gridTextColumn17.AllowFiltering = true;
            gridTextColumn17.AllowResizing = true;
            gridTextColumn17.HeaderText = "Type";
            gridTextColumn17.MappingName = "TYPE";
            gridTextColumn17.Width = 150D;
            gridTextColumn18.AllowFiltering = true;
            gridTextColumn18.AllowResizing = true;
            gridTextColumn18.HeaderText = "Contract";
            gridTextColumn18.MappingName = "CONTRACT";
            gridTextColumn18.Width = 200D;
            gridTextColumn19.AllowFiltering = true;
            gridTextColumn19.AllowResizing = true;
            gridTextColumn19.HeaderText = "Sub Ledger";
            gridTextColumn19.MappingName = "SUBLEDGER";
            gridTextColumn19.Width = 200D;
            gridTextColumn20.AllowFiltering = true;
            gridTextColumn20.AllowResizing = true;
            gridTextColumn20.HeaderText = "CC ID";
            gridTextColumn20.MappingName = "CID";
            gridTextColumn20.Width = 80D;
            gridTextColumn21.AllowFiltering = true;
            gridTextColumn21.AllowResizing = true;
            gridTextColumn21.HeaderText = "Cost Centre";
            gridTextColumn21.MappingName = "COSTCENTRE";
            gridTextColumn21.Width = 250D;
            gridTextColumn22.AllowFiltering = true;
            gridTextColumn22.AllowResizing = true;
            gridTextColumn22.HeaderText = "Client";
            gridTextColumn22.MappingName = "CLIENT";
            gridTextColumn22.Width = 300D;
            this.gridList.Columns.Add(gridTextColumn12);
            this.gridList.Columns.Add(gridTextColumn13);
            this.gridList.Columns.Add(gridTextColumn14);
            this.gridList.Columns.Add(gridTextColumn15);
            this.gridList.Columns.Add(gridTextColumn16);
            this.gridList.Columns.Add(gridTextColumn17);
            this.gridList.Columns.Add(gridTextColumn18);
            this.gridList.Columns.Add(gridTextColumn19);
            this.gridList.Columns.Add(gridTextColumn20);
            this.gridList.Columns.Add(gridTextColumn21);
            this.gridList.Columns.Add(gridTextColumn22);
            this.gridList.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Top;
            this.gridList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridList.FrozenColumnCount = 4;
            this.gridList.Location = new System.Drawing.Point(12, 57);
            this.gridList.Name = "gridList";
            this.gridList.PreviewRowHeight = 35;
            this.gridList.ShowGroupDropArea = true;
            this.gridList.ShowSortNumbers = true;
            this.gridList.Size = new System.Drawing.Size(1584, 587);
            this.gridList.Style.CellStyle.Font.Facename = "Arial";
            this.gridList.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridList.Style.HeaderStyle.Font.Bold = true;
            this.gridList.Style.HeaderStyle.TextColor = System.Drawing.Color.White;
            this.gridList.TabIndex = 2;
            this.gridList.Text = "sfDataGrid1";
            this.gridList.DrawCell += new Syncfusion.WinForms.DataGrid.Events.DrawCellEventHandler(this.gridList_DrawCell);
            this.gridList.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridList_QueryRowStyle);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(12, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Red;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListOfProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 656);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridList);
            this.Controls.Add(this.label1);
            this.Name = "frmListOfProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Of Projects";
            this.Load += new System.EventHandler(this.frmListOfProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridList;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}