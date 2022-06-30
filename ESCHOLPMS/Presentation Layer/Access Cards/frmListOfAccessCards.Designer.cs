namespace ESCHOLPMS
{
    partial class frmListOfAccessCards
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gridAccessCards = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnExport = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccessCards)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel1.Location = new System.Drawing.Point(263, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(271, 28);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "List of Access Cards";
            // 
            // gridAccessCards
            // 
            this.gridAccessCards.AccessibleName = "Table";
            gridTextColumn5.HeaderText = "Card Number";
            gridTextColumn5.MappingName = "CARDNUMBER";
            gridTextColumn5.Width = 110D;
            gridTextColumn6.HeaderText = "Worker Number";
            gridTextColumn6.MappingName = "WORKERNUMBER";
            gridTextColumn6.Width = 120D;
            gridTextColumn7.HeaderText = "Worker Name";
            gridTextColumn7.MappingName = "WORKERNAME";
            gridTextColumn7.Width = 250D;
            gridTextColumn8.HeaderText = "Status";
            gridTextColumn8.MappingName = "STATUS";
            gridTextColumn8.Width = 100D;
            this.gridAccessCards.Columns.Add(gridTextColumn5);
            this.gridAccessCards.Columns.Add(gridTextColumn6);
            this.gridAccessCards.Columns.Add(gridTextColumn7);
            this.gridAccessCards.Columns.Add(gridTextColumn8);
            this.gridAccessCards.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAccessCards.Location = new System.Drawing.Point(12, 107);
            this.gridAccessCards.Name = "gridAccessCards";
            this.gridAccessCards.PreviewRowHeight = 35;
            this.gridAccessCards.Size = new System.Drawing.Size(776, 662);
            this.gridAccessCards.TabIndex = 1;
            this.gridAccessCards.Text = "sfDataGrid1";
            // 
            // btnExport
            // 
            this.btnExport.AccessibleName = "Button";
            this.btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExport.Location = new System.Drawing.Point(13, 53);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(96, 28);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(692, 53);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListOfAccessCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 781);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gridAccessCards);
            this.Controls.Add(this.autoLabel1);
            this.Name = "frmListOfAccessCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Access Cards";
            this.Load += new System.EventHandler(this.frmListOfAccessCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAccessCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridAccessCards;
        private Syncfusion.WinForms.Controls.SfButton btnExport;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
    }
}