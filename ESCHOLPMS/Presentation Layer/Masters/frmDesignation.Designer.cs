namespace ESCHOLPMS 
{
    partial class frmDesignation
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
            Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer metroSplitButtonRenderer4 = new Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer metroSplitButtonRenderer5 = new Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer();
            Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer metroSplitButtonRenderer6 = new Syncfusion.Windows.Forms.Tools.MetroSplitButtonRenderer();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.btnAdd = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.btnClose = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.btnReset = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblDepartmentName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtDesignationName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.gridDesignation = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnFetch = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtHierarchyOrder = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignationName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDesignation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHierarchyOrder)).BeginInit();
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
            this.btnAdd.Location = new System.Drawing.Point(211, 218);
            this.btnAdd.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnAdd.Name = "btnAdd";
            metroSplitButtonRenderer4.SplitButton = this.btnAdd;
            this.btnAdd.Renderer = metroSplitButtonRenderer4;
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
            this.btnClose.Location = new System.Drawing.Point(538, 218);
            this.btnClose.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnClose.Name = "btnClose";
            metroSplitButtonRenderer5.SplitButton = this.btnClose;
            this.btnClose.Renderer = metroSplitButtonRenderer5;
            this.btnClose.ShowDropDownOnButtonClick = false;
            this.btnClose.Size = new System.Drawing.Size(146, 42);
            this.btnClose.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro;
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.ThemeName = "Metro";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnReset.BeforeTouchSize = new System.Drawing.Size(146, 42);
            this.btnReset.DropDownIconColor = System.Drawing.Color.White;
            this.btnReset.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.IsButtonChecked = true;
            this.btnReset.Location = new System.Drawing.Point(374, 218);
            this.btnReset.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnReset.Name = "btnReset";
            metroSplitButtonRenderer6.SplitButton = this.btnReset;
            this.btnReset.Renderer = metroSplitButtonRenderer6;
            this.btnReset.ShowDropDownOnButtonClick = false;
            this.btnReset.Size = new System.Drawing.Size(146, 42);
            this.btnReset.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Metro;
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.ThemeName = "Metro";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel1.Location = new System.Drawing.Point(282, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(205, 34);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Designation";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Location = new System.Drawing.Point(37, 110);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(111, 20);
            this.lblDepartmentName.TabIndex = 1;
            this.lblDepartmentName.Text = "Designation";
            // 
            // txtDesignationName
            // 
            this.txtDesignationName.BeforeTouchSize = new System.Drawing.Size(499, 28);
            this.txtDesignationName.Location = new System.Drawing.Point(211, 102);
            this.txtDesignationName.Name = "txtDesignationName";
            this.txtDesignationName.Size = new System.Drawing.Size(499, 28);
            this.txtDesignationName.TabIndex = 2;
            this.txtDesignationName.Text = "textBoxExt1";
            // 
            // gridDesignation
            // 
            this.gridDesignation.AccessibleName = "Table";
            gridTextColumn5.HeaderText = "Designation ";
            gridTextColumn5.MappingName = "DesignationName";
            gridTextColumn5.Width = 500D;
            gridTextColumn6.HeaderText = "Hierarchy";
            gridTextColumn6.MappingName = "HierarchyOrder";
            gridTextColumn6.Width = 150D;
            gridTextColumn7.HeaderText = "DepartmentID";
            gridTextColumn7.HeaderTextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            gridTextColumn7.MappingName = "DepartmentID";
            gridTextColumn7.Visible = false;
            gridTextColumn7.Width = 0D;
            gridTextColumn8.HeaderText = "DesignationCode";
            gridTextColumn8.MappingName = "DesignationCode";
            gridTextColumn8.Visible = false;
            gridTextColumn8.Width = 0D;
            this.gridDesignation.Columns.Add(gridTextColumn5);
            this.gridDesignation.Columns.Add(gridTextColumn6);
            this.gridDesignation.Columns.Add(gridTextColumn7);
            this.gridDesignation.Columns.Add(gridTextColumn8);
            this.gridDesignation.Location = new System.Drawing.Point(37, 266);
            this.gridDesignation.Name = "gridDesignation";
            this.gridDesignation.PreviewRowHeight = 35;
            this.gridDesignation.Size = new System.Drawing.Size(702, 355);
            this.gridDesignation.TabIndex = 5;
            this.gridDesignation.Text = "sfDataGrid1";
            this.gridDesignation.CellClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.gridDepartment_CellClick);
            // 
            // autoLabel3
            // 
            this.autoLabel3.Location = new System.Drawing.Point(37, 57);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(112, 20);
            this.autoLabel3.TabIndex = 9;
            this.autoLabel3.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DisplayMember = "DepartmentName";
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(211, 51);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(397, 28);
            this.cmbDepartment.TabIndex = 10;
            this.cmbDepartment.ValueMember = "DepartmentCode";
            // 
            // btnFetch
            // 
            this.btnFetch.AccessibleName = "Button";
            this.btnFetch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnFetch.ForeColor = System.Drawing.Color.Red;
            this.btnFetch.Location = new System.Drawing.Point(614, 49);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(96, 28);
            this.btnFetch.Style.ForeColor = System.Drawing.Color.Red;
            this.btnFetch.TabIndex = 11;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click_1);
            // 
            // autoLabel2
            // 
            this.autoLabel2.Location = new System.Drawing.Point(37, 165);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(138, 20);
            this.autoLabel2.TabIndex = 13;
            this.autoLabel2.Text = "Hierachy Order";
            // 
            // txtHierarchyOrder
            // 
            this.txtHierarchyOrder.BeforeTouchSize = new System.Drawing.Size(81, 28);
            this.txtHierarchyOrder.Location = new System.Drawing.Point(211, 157);
            this.txtHierarchyOrder.Name = "txtHierarchyOrder";
            this.txtHierarchyOrder.Size = new System.Drawing.Size(81, 28);
            this.txtHierarchyOrder.TabIndex = 15;
            // 
            // frmDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(751, 633);
            this.Controls.Add(this.txtHierarchyOrder);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridDesignation);
            this.Controls.Add(this.txtDesignationName);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDesignation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR | Designation";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignationName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDesignation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHierarchyOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblDepartmentName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDesignationName;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridDesignation;
        private Syncfusion.Windows.Forms.Tools.SplitButton btnAdd;
        private Syncfusion.Windows.Forms.Tools.SplitButton btnClose;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private Syncfusion.WinForms.Controls.SfButton btnFetch;
        private Syncfusion.Windows.Forms.Tools.SplitButton btnReset;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt txtHierarchyOrder;
    }
}