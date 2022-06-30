namespace ESCHOLPMS
{
    partial class frmStockMovement
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
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbPrivateJob = new Syncfusion.WinForms.ListView.SfComboBox();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dtTransferFrom = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtTransferTo = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.rdIssue = new System.Windows.Forms.RadioButton();
            this.rdReturn = new System.Windows.Forms.RadioButton();
            this.rdBoth = new System.Windows.Forms.RadioButton();
            this.btnPreview = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExport = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.gridResult = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPrivateJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Red;
            this.autoLabel1.Location = new System.Drawing.Point(319, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(255, 26);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Stock Movement Report";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Location = new System.Drawing.Point(13, 55);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(105, 19);
            this.autoLabel2.TabIndex = 1;
            this.autoLabel2.Text = "Private Job ?";
            // 
            // cmbPrivateJob
            // 
            this.cmbPrivateJob.DisplayMember = "WORKSHORTNAME";
            this.cmbPrivateJob.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbPrivateJob.Location = new System.Drawing.Point(170, 55);
            this.cmbPrivateJob.Name = "cmbPrivateJob";
            this.cmbPrivateJob.Size = new System.Drawing.Size(232, 32);
            this.cmbPrivateJob.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPrivateJob.TabIndex = 2;
            this.cmbPrivateJob.ValueMember = "PRIVATEWORKID";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Location = new System.Drawing.Point(12, 114);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(141, 19);
            this.autoLabel3.TabIndex = 3;
            this.autoLabel3.Text = "Transfer Between ";
            // 
            // dtTransferFrom
            // 
            this.dtTransferFrom.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate;
            this.dtTransferFrom.Location = new System.Drawing.Point(170, 98);
            this.dtTransferFrom.Name = "dtTransferFrom";
            this.dtTransferFrom.Size = new System.Drawing.Size(232, 34);
            this.dtTransferFrom.TabIndex = 4;
            // 
            // dtTransferTo
            // 
            this.dtTransferTo.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate;
            this.dtTransferTo.Location = new System.Drawing.Point(170, 149);
            this.dtTransferTo.Name = "dtTransferTo";
            this.dtTransferTo.Size = new System.Drawing.Size(232, 34);
            this.dtTransferTo.TabIndex = 5;
            // 
            // autoLabel4
            // 
            this.autoLabel4.Location = new System.Drawing.Point(12, 207);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(74, 19);
            this.autoLabel4.TabIndex = 6;
            this.autoLabel4.Text = "Transfer ";
            // 
            // rdIssue
            // 
            this.rdIssue.AutoSize = true;
            this.rdIssue.Location = new System.Drawing.Point(170, 207);
            this.rdIssue.Name = "rdIssue";
            this.rdIssue.Size = new System.Drawing.Size(69, 23);
            this.rdIssue.TabIndex = 7;
            this.rdIssue.TabStop = true;
            this.rdIssue.Text = "Issue";
            this.rdIssue.UseVisualStyleBackColor = true;
            // 
            // rdReturn
            // 
            this.rdReturn.AutoSize = true;
            this.rdReturn.Location = new System.Drawing.Point(332, 207);
            this.rdReturn.Name = "rdReturn";
            this.rdReturn.Size = new System.Drawing.Size(78, 23);
            this.rdReturn.TabIndex = 8;
            this.rdReturn.TabStop = true;
            this.rdReturn.Text = "Return";
            this.rdReturn.UseVisualStyleBackColor = true;
            // 
            // rdBoth
            // 
            this.rdBoth.AutoSize = true;
            this.rdBoth.Location = new System.Drawing.Point(490, 207);
            this.rdBoth.Name = "rdBoth";
            this.rdBoth.Size = new System.Drawing.Size(63, 23);
            this.rdBoth.TabIndex = 9;
            this.rdBoth.TabStop = true;
            this.rdBoth.Text = "Both";
            this.rdBoth.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.AccessibleName = "Button";
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnPreview.Location = new System.Drawing.Point(663, 55);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(96, 28);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnExport
            // 
            this.btnExport.AccessibleName = "Button";
            this.btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExport.Location = new System.Drawing.Point(663, 104);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(96, 28);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.Location = new System.Drawing.Point(663, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            // 
            // gridResult
            // 
            this.gridResult.AccessibleName = "Table";
            this.gridResult.Location = new System.Drawing.Point(13, 256);
            this.gridResult.Name = "gridResult";
            this.gridResult.PreviewRowHeight = 35;
            this.gridResult.Size = new System.Drawing.Size(875, 394);
            this.gridResult.TabIndex = 13;
            this.gridResult.Text = "sfDataGrid1";
            // 
            // frmStockMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 662);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.rdBoth);
            this.Controls.Add(this.rdReturn);
            this.Controls.Add(this.rdIssue);
            this.Controls.Add(this.autoLabel4);
            this.Controls.Add(this.dtTransferTo);
            this.Controls.Add(this.dtTransferFrom);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.cmbPrivateJob);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.autoLabel1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStockMovement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Movement";
            this.Load += new System.EventHandler(this.frmStockMovement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPrivateJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.WinForms.ListView.SfComboBox cmbPrivateJob;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtTransferFrom;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtTransferTo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private System.Windows.Forms.RadioButton rdIssue;
        private System.Windows.Forms.RadioButton rdReturn;
        private System.Windows.Forms.RadioButton rdBoth;
        private Syncfusion.WinForms.Controls.SfButton btnPreview;
        private Syncfusion.WinForms.Controls.SfButton btnExport;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridResult;
    }
}