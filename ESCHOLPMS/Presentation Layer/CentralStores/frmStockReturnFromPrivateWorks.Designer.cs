namespace ESCHOLPMS
{
    partial class frmStockReturnFromPrivateWorks
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
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPrivateJobs = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtReturnDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.gridResult = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnIssue = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnFetch = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPrivateJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(437, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Return From Private Jobs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Private Job ?";
            // 
            // cmbPrivateJobs
            // 
            this.cmbPrivateJobs.DisplayMember = "WORKSHORTNAME";
            this.cmbPrivateJobs.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbPrivateJobs.Location = new System.Drawing.Point(184, 54);
            this.cmbPrivateJobs.Name = "cmbPrivateJobs";
            this.cmbPrivateJobs.Size = new System.Drawing.Size(283, 32);
            this.cmbPrivateJobs.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPrivateJobs.TabIndex = 2;
            this.cmbPrivateJobs.ValueMember = "PRIVATEWORKID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Return  Date";
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate;
            this.dtReturnDate.Location = new System.Drawing.Point(184, 113);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(283, 34);
            this.dtReturnDate.TabIndex = 4;
            // 
            // gridResult
            // 
            this.gridResult.AccessibleName = "Table";
            this.gridResult.AllowFiltering = true;
            this.gridResult.AllowGrouping = false;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.AllowGrouping = false;
            gridTextColumn1.HeaderText = "Column2";
            gridTextColumn1.MappingName = "MATERIALID";
            gridTextColumn1.Visible = false;
            gridTextColumn1.Width = 0D;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.AllowGrouping = false;
            gridTextColumn2.HeaderText = "Material Name";
            gridTextColumn2.MappingName = "MATERIALNAME";
            gridTextColumn2.Width = 400D;
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.AllowGrouping = false;
            gridTextColumn3.HeaderText = "Unit";
            gridTextColumn3.MappingName = "UOMNAME";
            gridTextColumn3.Width = 100D;
            gridNumericColumn1.AllowEditing = false;
            gridNumericColumn1.AllowFiltering = true;
            gridNumericColumn1.AllowGrouping = false;
            gridNumericColumn1.HeaderText = "Issued";
            gridNumericColumn1.MappingName = "ISSUEDQTY";
            gridNumericColumn1.Width = 180D;
            gridNumericColumn2.AllowFiltering = true;
            gridNumericColumn2.AllowGrouping = false;
            gridNumericColumn2.HeaderText = "Return";
            gridNumericColumn2.MappingName = "RETURNQTY";
            gridNumericColumn2.Width = 180D;
            this.gridResult.Columns.Add(gridTextColumn1);
            this.gridResult.Columns.Add(gridTextColumn2);
            this.gridResult.Columns.Add(gridTextColumn3);
            this.gridResult.Columns.Add(gridNumericColumn1);
            this.gridResult.Columns.Add(gridNumericColumn2);
            this.gridResult.Location = new System.Drawing.Point(37, 169);
            this.gridResult.Name = "gridResult";
            this.gridResult.PreviewRowHeight = 35;
            this.gridResult.ShowSortNumbers = true;
            this.gridResult.Size = new System.Drawing.Size(1091, 501);
            this.gridResult.TabIndex = 5;
            this.gridResult.Text = "sfDataGrid1";
            this.gridResult.DrawCell += new Syncfusion.WinForms.DataGrid.Events.DrawCellEventHandler(this.gridResult_DrawCell);
            this.gridResult.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridResult_QueryRowStyle);
            // 
            // btnIssue
            // 
            this.btnIssue.AccessibleName = "Button";
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnIssue.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnIssue.Location = new System.Drawing.Point(819, 54);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(96, 28);
            this.btnIssue.Style.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnIssue.TabIndex = 6;
            this.btnIssue.Text = "Return";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Location = new System.Drawing.Point(1032, 54);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.AccessibleName = "Button";
            this.btnFetch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnFetch.ForeColor = System.Drawing.Color.Indigo;
            this.btnFetch.Location = new System.Drawing.Point(484, 59);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(96, 28);
            this.btnFetch.Style.ForeColor = System.Drawing.Color.Indigo;
            this.btnFetch.TabIndex = 8;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // frmStockReturnFromPrivateWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 700);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.dtReturnDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPrivateJobs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStockReturnFromPrivateWorks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Return From Private Jobs";
            this.Load += new System.EventHandler(this.frmStockIssueToPrivateWorks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPrivateJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.WinForms.ListView.SfComboBox cmbPrivateJobs;
        private System.Windows.Forms.Label label3;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtReturnDate;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridResult;
        private Syncfusion.WinForms.Controls.SfButton btnIssue;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.Controls.SfButton btnFetch;
    }
}