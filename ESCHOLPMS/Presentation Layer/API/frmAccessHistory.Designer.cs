namespace ESCHOLPMS 
{
    partial class frmAccessHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gridSites = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dtStartDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtEndDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbAccessPoint = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccessPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Access History";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(803, 62);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(119, 39);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // gridSites
            // 
            this.gridSites.AccessibleName = "Table";
            gridTextColumn6.HeaderText = "ACCESSPOINTSID";
            gridTextColumn6.MappingName = "ACCESSPOINTSID";
            gridTextColumn6.Visible = false;
            gridTextColumn6.Width = 0D;
            gridTextColumn7.HeaderText = "SITE ID";
            gridTextColumn7.MappingName = "SITEID";
            gridTextColumn7.Width = 100D;
            gridTextColumn8.HeaderText = "Site Name";
            gridTextColumn8.MappingName = "SITENAME";
            gridTextColumn8.Width = 200D;
            gridTextColumn9.HeaderText = "Access Point ID";
            gridTextColumn9.MappingName = "SPINTLYACCESSPOINTID";
            gridTextColumn9.Width = 120D;
            gridTextColumn10.HeaderText = "Access Point Name";
            gridTextColumn10.MappingName = "ACCESSPOINTNAME";
            gridTextColumn10.Width = 250D;
            this.gridSites.Columns.Add(gridTextColumn6);
            this.gridSites.Columns.Add(gridTextColumn7);
            this.gridSites.Columns.Add(gridTextColumn8);
            this.gridSites.Columns.Add(gridTextColumn9);
            this.gridSites.Columns.Add(gridTextColumn10);
            this.gridSites.Location = new System.Drawing.Point(24, 188);
            this.gridSites.Name = "gridSites";
            this.gridSites.PreviewRowHeight = 35;
            this.gridSites.Size = new System.Drawing.Size(898, 474);
            this.gridSites.TabIndex = 2;
            this.gridSites.Text = "sfDataGrid1";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(24, 44);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(57, 19);
            this.autoLabel1.TabIndex = 3;
            this.autoLabel1.Text = "Period";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Location = new System.Drawing.Point(24, 67);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(317, 34);
            this.dtStartDate.TabIndex = 4;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Location = new System.Drawing.Point(356, 67);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(317, 34);
            this.dtEndDate.TabIndex = 5;
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.Location = new System.Drawing.Point(24, 114);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(113, 19);
            this.autoLabel2.TabIndex = 7;
            this.autoLabel2.Text = "Access Points";
            // 
            // cmbAccessPoint
            // 
            this.cmbAccessPoint.DisplayMember = "ACCESSPOINT";
            this.cmbAccessPoint.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbAccessPoint.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessPoint.Location = new System.Drawing.Point(24, 136);
            this.cmbAccessPoint.Name = "cmbAccessPoint";
            this.cmbAccessPoint.Size = new System.Drawing.Size(649, 32);
            this.cmbAccessPoint.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessPoint.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessPoint.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbAccessPoint.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessPoint.TabIndex = 8;
            this.cmbAccessPoint.ValueMember = "SPINTLYACCESSPOINTID";
            // 
            // frmAccessHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 688);
            this.Controls.Add(this.cmbAccessPoint);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.gridSites);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Name = "frmAccessHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API | Access History";
            this.Load += new System.EventHandler(this.frmAccessHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccessPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridSites;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtStartDate;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtEndDate;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.WinForms.ListView.SfComboBox cmbAccessPoint;
    }
}