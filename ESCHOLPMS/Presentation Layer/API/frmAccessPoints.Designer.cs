namespace ESCHOLPMS 
{
    partial class frmAccessPoints
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gridSites = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridSites)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Access Points Where Access Devices Fixed";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(24, 40);
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
            gridTextColumn1.HeaderText = "ACCESSPOINTSID";
            gridTextColumn1.MappingName = "ACCESSPOINTSID";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 0D;
            gridTextColumn2.HeaderText = "GateWay ID";
            gridTextColumn2.MappingName = "GATEWAYID";
            gridTextColumn2.Width = 100D;
            gridTextColumn3.HeaderText = "Gate Way Name";
            gridTextColumn3.MappingName = "GATEWAYNAME";
            gridTextColumn3.Width = 200D;
            gridTextColumn4.HeaderText = "Access Point ID";
            gridTextColumn4.MappingName = "SPINTLYACCESSPOINTID";
            gridTextColumn4.Width = 120D;
            gridTextColumn5.HeaderText = "Access Point Name";
            gridTextColumn5.MappingName = "ACCESSPOINTNAME";
            gridTextColumn5.Width = 250D;
            this.gridSites.Columns.Add(gridTextColumn1);
            this.gridSites.Columns.Add(gridTextColumn2);
            this.gridSites.Columns.Add(gridTextColumn3);
            this.gridSites.Columns.Add(gridTextColumn4);
            this.gridSites.Columns.Add(gridTextColumn5);
            this.gridSites.Location = new System.Drawing.Point(24, 85);
            this.gridSites.Name = "gridSites";
            this.gridSites.PreviewRowHeight = 35;
            this.gridSites.Size = new System.Drawing.Size(898, 577);
            this.gridSites.TabIndex = 2;
            this.gridSites.Text = "sfDataGrid1";
            // 
            // frmAccessPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 688);
            this.Controls.Add(this.gridSites);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Name = "frmAccessPoints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API | Project Sites";
            ((System.ComponentModel.ISupportInitialize)(this.gridSites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridSites;
    }
}