namespace ESCHOLPMS 
{
    partial class frmProjectAccessPoints
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn9 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn10 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn2 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gridSites = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbProjects = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbGateWays = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbAccessPoint = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnAdd = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridSites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGateWays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccessPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(500, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects - Access Point List";
            // 
            // gridSites
            // 
            this.gridSites.AccessibleName = "Table";
            gridTextColumn6.HeaderText = "Project Name";
            gridTextColumn6.MappingName = "PROJECTNAME";
            gridTextColumn6.Width = 300D;
            gridTextColumn7.HeaderText = "GateWay ID";
            gridTextColumn7.MappingName = "GATEWAYID";
            gridTextColumn7.Width = 120D;
            gridTextColumn8.HeaderText = "Gate Way Name";
            gridTextColumn8.MappingName = "GATEWAYNAME";
            gridTextColumn8.Width = 200D;
            gridTextColumn9.HeaderText = "Access Point ID";
            gridTextColumn9.MappingName = "ACCESSPOINTID";
            gridTextColumn9.Width = 120D;
            gridTextColumn10.HeaderText = "Access Point Name";
            gridTextColumn10.MappingName = "ACCESSPOINTNAME";
            gridTextColumn10.Width = 250D;
            gridDateTimeColumn2.HeaderText = "Updated";
            gridDateTimeColumn2.MappingName = "UPDATEDON";
            gridDateTimeColumn2.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.gridSites.Columns.Add(gridTextColumn6);
            this.gridSites.Columns.Add(gridTextColumn7);
            this.gridSites.Columns.Add(gridTextColumn8);
            this.gridSites.Columns.Add(gridTextColumn9);
            this.gridSites.Columns.Add(gridTextColumn10);
            this.gridSites.Columns.Add(gridDateTimeColumn2);
            this.gridSites.Location = new System.Drawing.Point(24, 244);
            this.gridSites.Name = "gridSites";
            this.gridSites.PreviewRowHeight = 35;
            this.gridSites.Size = new System.Drawing.Size(1278, 418);
            this.gridSites.TabIndex = 2;
            this.gridSites.Text = "sfDataGrid1";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(24, 51);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(117, 19);
            this.autoLabel1.TabIndex = 3;
            this.autoLabel1.Text = "Project Name :";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.Location = new System.Drawing.Point(24, 112);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(92, 19);
            this.autoLabel2.TabIndex = 4;
            this.autoLabel2.Text = "Gate Way :";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.Location = new System.Drawing.Point(24, 184);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(106, 19);
            this.autoLabel3.TabIndex = 5;
            this.autoLabel3.Text = "Acess Point :";
            // 
            // cmbProjects
            // 
            this.cmbProjects.DisplayMember = "PROJECTNAME";
            this.cmbProjects.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbProjects.Location = new System.Drawing.Point(243, 51);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(494, 32);
            this.cmbProjects.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProjects.TabIndex = 6;
            this.cmbProjects.ValueMember = "PROJECTCODE";
            // 
            // cmbGateWays
            // 
            this.cmbGateWays.DisplayMember = "GATEWAYNAME";
            this.cmbGateWays.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbGateWays.Location = new System.Drawing.Point(243, 112);
            this.cmbGateWays.Name = "cmbGateWays";
            this.cmbGateWays.Size = new System.Drawing.Size(494, 32);
            this.cmbGateWays.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGateWays.TabIndex = 7;
            this.cmbGateWays.ValueMember = "SPINTLYGATEWAYID";
            this.cmbGateWays.SelectedIndexChanged += new System.EventHandler(this.cmbGateWays_SelectedIndexChanged);
            // 
            // cmbAccessPoint
            // 
            this.cmbAccessPoint.DisplayMember = "ACCESSPOINTNAME";
            this.cmbAccessPoint.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbAccessPoint.Location = new System.Drawing.Point(243, 171);
            this.cmbAccessPoint.Name = "cmbAccessPoint";
            this.cmbAccessPoint.Size = new System.Drawing.Size(494, 32);
            this.cmbAccessPoint.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbAccessPoint.TabIndex = 8;
            this.cmbAccessPoint.ValueMember = "SPINTLYACCESSPOINTID";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "Button";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAdd.Location = new System.Drawing.Point(822, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 28);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(985, 171);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmProjectAccessPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 688);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbAccessPoint);
            this.Controls.Add(this.cmbGateWays);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.gridSites);
            this.Controls.Add(this.label1);
            this.Name = "frmProjectAccessPoints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API | Project Access Points";
            this.Load += new System.EventHandler(this.frmProjectAccessPoints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGateWays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccessPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridSites;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.WinForms.ListView.SfComboBox cmbProjects;
        private Syncfusion.WinForms.ListView.SfComboBox cmbGateWays;
        private Syncfusion.WinForms.ListView.SfComboBox cmbAccessPoint;
        private Syncfusion.WinForms.Controls.SfButton btnAdd;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}