namespace ESCHOLPMS 
{
    partial class frmLinkedAccounts
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
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gridLinked = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridLinked)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(311, -1);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(223, 28);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Linked Accounts";
            // 
            // gridLinked
            // 
            this.gridLinked.AccessibleName = "Table";
            this.gridLinked.AllowEditing = false;
            this.gridLinked.AllowGrouping = false;
            this.gridLinked.AllowSorting = false;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.AllowGrouping = false;
            gridTextColumn1.AllowSorting = false;
            gridTextColumn1.HeaderText = "Sub Contractor Name";
            gridTextColumn1.MappingName = "SUBCONTRACTOR";
            gridTextColumn1.Width = 250D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.AllowGrouping = false;
            gridTextColumn2.AllowSorting = false;
            gridTextColumn2.HeaderText = "SlNo";
            gridTextColumn2.MappingName = "ELEMENTID";
            gridTextColumn2.Width = 50D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.AllowGrouping = false;
            gridTextColumn3.AllowSorting = false;
            gridTextColumn3.HeaderText = "Linked Account Name";
            gridTextColumn3.MappingName = "LINKEDACCOUNT";
            gridTextColumn3.Width = 300D;
            this.gridLinked.Columns.Add(gridTextColumn1);
            this.gridLinked.Columns.Add(gridTextColumn2);
            this.gridLinked.Columns.Add(gridTextColumn3);
            this.gridLinked.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLinked.Location = new System.Drawing.Point(12, 40);
            this.gridLinked.Name = "gridLinked";
            this.gridLinked.PreviewRowHeight = 35;
            this.gridLinked.Size = new System.Drawing.Size(888, 669);
            this.gridLinked.TabIndex = 1;
            this.gridLinked.Text = "sfDataGrid1";
            this.gridLinked.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridLinked_QueryRowStyle);
            // 
            // frmLinkedAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 715);
            this.Controls.Add(this.gridLinked);
            this.Controls.Add(this.autoLabel1);
            this.Name = "frmLinkedAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linked Accounts";
            this.Load += new System.EventHandler(this.frmLinkedAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLinked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridLinked;
    }
}