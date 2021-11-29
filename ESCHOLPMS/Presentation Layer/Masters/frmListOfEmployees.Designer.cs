namespace ESCHOLPMS
{
    partial class frmListOfEmployees
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.btnClose = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gridEmployeeLists = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNewEmployee = new System.Windows.Forms.Panel();
            this.btnCloseNewEmployee = new System.Windows.Forms.Button();
            this.btnSaveNewEmployee = new System.Windows.Forms.Button();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeLists)).BeginInit();
            this.panelNewEmployee.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(1124, 12);
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
            this.autoLabel1.Location = new System.Drawing.Point(463, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(403, 34);
            this.autoLabel1.TabIndex = 1;
            this.autoLabel1.Text = "List of Active Employees";
            // 
            // gridEmployeeLists
            // 
            this.gridEmployeeLists.AccessibleName = "Table";
            this.gridEmployeeLists.AllowFiltering = true;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "EmployeeCode";
            gridTextColumn1.MappingName = "EmployeeCode";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 0D;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Emp Number";
            gridTextColumn2.MappingName = "EmployeeNumber";
            gridTextColumn2.Width = 150D;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Employee Name";
            gridTextColumn3.MappingName = "EmployeeName";
            gridTextColumn3.Width = 300D;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Designation";
            gridTextColumn4.MappingName = "Designation";
            gridTextColumn4.Width = 200D;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "Department";
            gridTextColumn5.MappingName = "Department";
            gridTextColumn5.Width = 200D;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "Unit";
            gridTextColumn6.MappingName = "UnitName";
            gridTextColumn6.Width = 250D;
            gridTextColumn7.AllowFiltering = true;
            gridTextColumn7.HeaderText = "Status";
            gridTextColumn7.MappingName = "CurrentStatus";
            gridTextColumn7.Width = 120D;
            this.gridEmployeeLists.Columns.Add(gridTextColumn1);
            this.gridEmployeeLists.Columns.Add(gridTextColumn2);
            this.gridEmployeeLists.Columns.Add(gridTextColumn3);
            this.gridEmployeeLists.Columns.Add(gridTextColumn4);
            this.gridEmployeeLists.Columns.Add(gridTextColumn5);
            this.gridEmployeeLists.Columns.Add(gridTextColumn6);
            this.gridEmployeeLists.Columns.Add(gridTextColumn7);
            this.gridEmployeeLists.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEmployeeLists.Location = new System.Drawing.Point(13, 57);
            this.gridEmployeeLists.Name = "gridEmployeeLists";
            this.gridEmployeeLists.PreviewRowHeight = 35;
            this.gridEmployeeLists.ShowSortNumbers = true;
            this.gridEmployeeLists.Size = new System.Drawing.Size(1263, 515);
            this.gridEmployeeLists.TabIndex = 9;
            this.gridEmployeeLists.Text = "sfDataGrid1";
            this.gridEmployeeLists.ThemeName = "Office2016Colorful";
            this.gridEmployeeLists.DrawCell += new Syncfusion.WinForms.DataGrid.Events.DrawCellEventHandler(this.gridEmployeeLists_DrawCell);
            this.gridEmployeeLists.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridEmployeeLists_QueryRowStyle);
            this.gridEmployeeLists.CellClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.gridEmployeeLists_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // panelNewEmployee
            // 
            this.panelNewEmployee.BackColor = System.Drawing.Color.MistyRose;
            this.panelNewEmployee.Controls.Add(this.btnCloseNewEmployee);
            this.panelNewEmployee.Controls.Add(this.btnSaveNewEmployee);
            this.panelNewEmployee.Controls.Add(this.txtEmployeeName);
            this.panelNewEmployee.Controls.Add(this.txtEmployeeCode);
            this.panelNewEmployee.Controls.Add(this.label3);
            this.panelNewEmployee.Controls.Add(this.label2);
            this.panelNewEmployee.Location = new System.Drawing.Point(400, 259);
            this.panelNewEmployee.Name = "panelNewEmployee";
            this.panelNewEmployee.Size = new System.Drawing.Size(595, 211);
            this.panelNewEmployee.TabIndex = 12;
            // 
            // btnCloseNewEmployee
            // 
            this.btnCloseNewEmployee.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseNewEmployee.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnCloseNewEmployee.Location = new System.Drawing.Point(462, 164);
            this.btnCloseNewEmployee.Name = "btnCloseNewEmployee";
            this.btnCloseNewEmployee.Size = new System.Drawing.Size(116, 33);
            this.btnCloseNewEmployee.TabIndex = 5;
            this.btnCloseNewEmployee.Text = "Close";
            this.btnCloseNewEmployee.UseVisualStyleBackColor = true;
            // 
            // btnSaveNewEmployee
            // 
            this.btnSaveNewEmployee.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewEmployee.ForeColor = System.Drawing.Color.Blue;
            this.btnSaveNewEmployee.Location = new System.Drawing.Point(20, 164);
            this.btnSaveNewEmployee.Name = "btnSaveNewEmployee";
            this.btnSaveNewEmployee.Size = new System.Drawing.Size(116, 33);
            this.btnSaveNewEmployee.TabIndex = 4;
            this.btnSaveNewEmployee.Text = "Save";
            this.btnSaveNewEmployee.UseVisualStyleBackColor = true;
            this.btnSaveNewEmployee.Click += new System.EventHandler(this.btnSaveNewEmployee_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(91, 105);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(487, 26);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(168, 32);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(117, 26);
            this.txtEmployeeCode.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee Code :";
            // 
            // btnNew
            // 
            this.btnNew.AccessibleName = "Button";
            this.btnNew.BackColor = System.Drawing.Color.Fuchsia;
            this.btnNew.FocusRectangleVisible = true;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnNew.Location = new System.Drawing.Point(13, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(163, 39);
            this.btnNew.Style.BackColor = System.Drawing.Color.Fuchsia;
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmListOfEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 598);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panelNewEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridEmployeeLists);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmListOfEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Employees";
            this.Load += new System.EventHandler(this.frmListOfEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeLists)).EndInit();
            this.panelNewEmployee.ResumeLayout(false);
            this.panelNewEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.SplitButton btnClose;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridEmployeeLists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNewEmployee;
        private System.Windows.Forms.Button btnCloseNewEmployee;
        private System.Windows.Forms.Button btnSaveNewEmployee;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Syncfusion.WinForms.Controls.SfButton btnNew;
    }
}