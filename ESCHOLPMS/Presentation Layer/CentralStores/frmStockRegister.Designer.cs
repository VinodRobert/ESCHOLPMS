namespace ESCHOLPMS 
{
    partial class frmStockRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridReport = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.btnExport = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.cmbCostCentre = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbFromYear = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbFromMonth = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbToYear = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cmbToMonth = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnFetch = new Syncfusion.WinForms.Controls.SfButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCostCentre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFromYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFromMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbToYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbToMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(608, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Register";
            // 
            // gridReport
            // 
            this.gridReport.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridReport.BackColor = System.Drawing.SystemColors.Window;
            this.gridReport.Location = new System.Drawing.Point(13, 103);
            this.gridReport.Name = "gridReport";
            this.gridReport.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridReport.Size = new System.Drawing.Size(1418, 649);
            this.gridReport.TabIndex = 1;
            this.gridReport.Text = "gridReport";
            this.gridReport.UseRightToLeftCompatibleTextBox = true;
            this.gridReport.VersionInfo = "20.1460.0.47";
            // 
            // btnExport
            // 
            this.btnExport.AccessibleName = "Button";
            this.btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExport.ForeColor = System.Drawing.Color.Blue;
            this.btnExport.Location = new System.Drawing.Point(1305, 9);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(126, 28);
            this.btnExport.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1305, 43);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 28);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Red;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbCostCentre
            // 
            this.cmbCostCentre.DisplayMember = "COSTCENTRE";
            this.cmbCostCentre.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbCostCentre.Location = new System.Drawing.Point(13, 65);
            this.cmbCostCentre.Name = "cmbCostCentre";
            this.cmbCostCentre.Size = new System.Drawing.Size(476, 32);
            this.cmbCostCentre.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCostCentre.TabIndex = 4;
            this.cmbCostCentre.ValueMember = "COSTCENTREID";
            // 
            // cmbFromYear
            // 
            this.cmbFromYear.DisplayMember = "YearID";
            this.cmbFromYear.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbFromYear.Location = new System.Drawing.Point(589, 65);
            this.cmbFromYear.Name = "cmbFromYear";
            this.cmbFromYear.Size = new System.Drawing.Size(83, 32);
            this.cmbFromYear.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbFromYear.TabIndex = 5;
            this.cmbFromYear.ValueMember = "YearID";
            // 
            // cmbFromMonth
            // 
            this.cmbFromMonth.DisplayMember = "MonthName";
            this.cmbFromMonth.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbFromMonth.Location = new System.Drawing.Point(678, 65);
            this.cmbFromMonth.Name = "cmbFromMonth";
            this.cmbFromMonth.Size = new System.Drawing.Size(211, 32);
            this.cmbFromMonth.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbFromMonth.TabIndex = 6;
            this.cmbFromMonth.ValueMember = "MonthID";
            // 
            // cmbToYear
            // 
            this.cmbToYear.DisplayMember = "YearID";
            this.cmbToYear.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbToYear.Location = new System.Drawing.Point(918, 65);
            this.cmbToYear.Name = "cmbToYear";
            this.cmbToYear.Size = new System.Drawing.Size(74, 32);
            this.cmbToYear.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbToYear.TabIndex = 7;
            this.cmbToYear.ValueMember = "YearID";
            // 
            // cmbToMonth
            // 
            this.cmbToMonth.DisplayMember = "MonthName";
            this.cmbToMonth.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbToMonth.Location = new System.Drawing.Point(997, 65);
            this.cmbToMonth.Name = "cmbToMonth";
            this.cmbToMonth.Size = new System.Drawing.Size(202, 32);
            this.cmbToMonth.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbToMonth.TabIndex = 8;
            this.cmbToMonth.ValueMember = "MonthID";
            // 
            // btnFetch
            // 
            this.btnFetch.AccessibleName = "Button";
            this.btnFetch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnFetch.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnFetch.Location = new System.Drawing.Point(1205, 65);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(126, 28);
            this.btnFetch.Style.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnFetch.TabIndex = 9;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost Centre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(589, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "From Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(918, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "To Period";
            // 
            // frmStockRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 764);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.cmbToMonth);
            this.Controls.Add(this.cmbToYear);
            this.Controls.Add(this.cmbFromMonth);
            this.Controls.Add(this.cmbFromYear);
            this.Controls.Add(this.cmbCostCentre);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gridReport);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmStockRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Register";
            this.Load += new System.EventHandler(this.frmCSTMReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCostCentre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFromYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFromMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbToYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbToMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridReport;
        private Syncfusion.WinForms.Controls.SfButton btnExport;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.WinForms.ListView.SfComboBox cmbCostCentre;
        private Syncfusion.WinForms.ListView.SfComboBox cmbFromYear;
        private Syncfusion.WinForms.ListView.SfComboBox cmbFromMonth;
        private Syncfusion.WinForms.ListView.SfComboBox cmbToYear;
        private Syncfusion.WinForms.ListView.SfComboBox cmbToMonth;
        private Syncfusion.WinForms.Controls.SfButton btnFetch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}