namespace ESCHOLPMS 
{
    partial class frmAccessUsers
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
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn1 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn2 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gridUsers = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Users";
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
            // gridUsers
            // 
            this.gridUsers.AccessibleName = "Table";
            gridTextColumn1.HeaderText = "Spintly ID";
            gridTextColumn1.MappingName = "SPINTLYID";
            gridTextColumn1.Width = 80D;
            gridTextColumn2.HeaderText = "Name";
            gridTextColumn2.MappingName = "NAME";
            gridTextColumn2.Width = 150D;
            gridTextColumn3.HeaderText = "Emp Code";
            gridTextColumn3.MappingName = "EMPLOYEECODE";
            gridTextColumn3.Width = 80D;
            gridTextColumn4.HeaderText = "Access Card #";
            gridTextColumn4.MappingName = "ACCESSCARDNO";
            gridTextColumn4.Width = 80D;
            gridDateTimeColumn1.HeaderText = "Exiprty ON";
            gridDateTimeColumn1.MappingName = "ACCESSEXPIREDAT";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Width = 50D;
            gridCheckBoxColumn1.HeaderText = "Expired";
            gridCheckBoxColumn1.MappingName = "ACCESSEXPIRED";
            gridCheckBoxColumn1.Width = 80D;
            gridDateTimeColumn2.HeaderText = "Deactivated ON";
            gridDateTimeColumn2.MappingName = "DEACTIVATEDON";
            gridDateTimeColumn2.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn2.Width = 90D;
            this.gridUsers.Columns.Add(gridTextColumn1);
            this.gridUsers.Columns.Add(gridTextColumn2);
            this.gridUsers.Columns.Add(gridTextColumn3);
            this.gridUsers.Columns.Add(gridTextColumn4);
            this.gridUsers.Columns.Add(gridDateTimeColumn1);
            this.gridUsers.Columns.Add(gridCheckBoxColumn1);
            this.gridUsers.Columns.Add(gridDateTimeColumn2);
            this.gridUsers.Location = new System.Drawing.Point(24, 85);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.PreviewRowHeight = 35;
            this.gridUsers.Size = new System.Drawing.Size(921, 577);
            this.gridUsers.TabIndex = 2;
            this.gridUsers.Text = "sfDataGrid1";
            // 
            // frmAccessUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 688);
            this.Controls.Add(this.gridUsers);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Name = "frmAccessUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API | Users";
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridUsers;
    }
}