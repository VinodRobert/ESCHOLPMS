namespace ESCHOLPMS 
{
    partial class frmCostCentre
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
            Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer metroSplitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.btnClose = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(146, 42);
            this.btnClose.DropDownIconColor = System.Drawing.Color.White;
            this.btnClose.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IsButtonChecked = true;
            this.btnClose.Location = new System.Drawing.Point(994, 27);
            this.btnClose.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnClose.Name = "btnClose";
            metroSplitButtonRenderer1.SplitButton = this.btnClose;
            this.btnClose.Renderer = metroSplitButtonRenderer1;
            this.btnClose.ShowDropDownOnButtonClick = false;
            this.btnClose.Size = new System.Drawing.Size(146, 42);
            this.btnClose.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro;
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.ThemeName = "Metro";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel1.Location = new System.Drawing.Point(453, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(199, 34);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Cost Centre";
            // 
            // grid
            // 
            this.grid.AccessibleName = "Table";
            this.grid.AllowFiltering = true;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "Code";
            gridTextColumn1.MappingName = "COSTCENTRECODE";
            gridTextColumn1.Width = 120D;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Parent";
            gridTextColumn2.MappingName = "PARENT";
            gridTextColumn2.Width = 200D;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Cost Centre";
            gridTextColumn3.MappingName = "COSTCENTRE";
            gridTextColumn3.Width = 600D;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Short Name";
            gridTextColumn4.MappingName = "SHORTNAME";
            gridTextColumn4.Width = 120D;
            this.grid.Columns.Add(gridTextColumn1);
            this.grid.Columns.Add(gridTextColumn2);
            this.grid.Columns.Add(gridTextColumn3);
            this.grid.Columns.Add(gridTextColumn4);
            this.grid.Location = new System.Drawing.Point(12, 75);
            this.grid.Name = "grid";
            this.grid.PreviewRowHeight = 35;
            this.grid.Size = new System.Drawing.Size(1128, 546);
            this.grid.TabIndex = 5;
            this.grid.Text = "sfDataGrid1";
            // 
            // frmCostCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1152, 633);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCostCentre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR | Cost Centre";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid grid;
        private Syncfusion.Windows.Forms.Tools.SplitButton btnClose;
    }
}