namespace ESCHOLPMS 
{
    partial class frmDepartment
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
            Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer metroSplitButtonRenderer2 = new Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.btnAdd = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.btnClose = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblDepartmentName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtDepartmentName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.gridDepartment = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnAdd.BeforeTouchSize = new System.Drawing.Size(146, 42);
            this.btnAdd.DropDownIconColor = System.Drawing.Color.White;
            this.btnAdd.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IsButtonChecked = true;
            this.btnAdd.Location = new System.Drawing.Point(211, 125);
            this.btnAdd.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnAdd.Name = "btnAdd";
            metroSplitButtonRenderer1.SplitButton = this.btnAdd;
            this.btnAdd.Renderer = metroSplitButtonRenderer1;
            this.btnAdd.ShowDropDownOnButtonClick = false;
            this.btnAdd.Size = new System.Drawing.Size(146, 42);
            this.btnAdd.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro;
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Save";
            this.btnAdd.ThemeName = "Metro";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnClose.Location = new System.Drawing.Point(404, 125);
            this.btnClose.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnClose.Name = "btnClose";
            metroSplitButtonRenderer2.SplitButton = this.btnClose;
            this.btnClose.Renderer = metroSplitButtonRenderer2;
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
            this.autoLabel1.Location = new System.Drawing.Point(275, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(205, 34);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Department";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Location = new System.Drawing.Point(37, 69);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(168, 20);
            this.lblDepartmentName.TabIndex = 1;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.BeforeTouchSize = new System.Drawing.Size(480, 28);
            this.txtDepartmentName.Location = new System.Drawing.Point(211, 61);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(480, 28);
            this.txtDepartmentName.TabIndex = 2;
            this.txtDepartmentName.Text = "textBoxExt1";
            // 
            // gridDepartment
            // 
            this.gridDepartment.AccessibleName = "Table";
            gridTextColumn1.HeaderText = "Column1";
            gridTextColumn1.MappingName = "RowSlNo";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 0D;
            gridTextColumn2.HeaderText = "Column2";
            gridTextColumn2.MappingName = "DepartmentCode";
            gridTextColumn2.Visible = false;
            gridTextColumn2.Width = 0D;
            gridTextColumn3.HeaderText = "Department Name";
            gridTextColumn3.MappingName = "DepartmentName";
            gridTextColumn3.Width = 600D;
            this.gridDepartment.Columns.Add(gridTextColumn1);
            this.gridDepartment.Columns.Add(gridTextColumn2);
            this.gridDepartment.Columns.Add(gridTextColumn3);
            this.gridDepartment.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Top;
            this.gridDepartment.Location = new System.Drawing.Point(74, 197);
            this.gridDepartment.Name = "gridDepartment";
            this.gridDepartment.PreviewRowHeight = 35;
            this.gridDepartment.Size = new System.Drawing.Size(637, 424);
            this.gridDepartment.TabIndex = 5;
            this.gridDepartment.Text = "sfDataGrid1";
            this.gridDepartment.CellClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.gridDepartment_CellClick);
            this.gridDepartment.CellButtonClick += new Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventHandler(this.gridDepartment_CellButtonClick);
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(751, 633);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridDepartment);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR | Department";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblDepartmentName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDepartmentName;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridDepartment;
        private Syncfusion.Windows.Forms.Tools.SplitButton btnAdd;
        private Syncfusion.Windows.Forms.Tools.SplitButton btnClose;
    }
}