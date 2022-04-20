namespace ESCHOLPMS 
{
    partial class frmOpeningBalance
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
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbFinYear = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnFetch = new Syncfusion.WinForms.Controls.SfButton();
            this.gridLedgers = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblLedger = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbLedger = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnFetchSubLedger = new Syncfusion.WinForms.Controls.SfButton();
            this.lblSubLedger = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbSubLedger = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnAdd = new Syncfusion.WinForms.Controls.SfButton();
            this.panelAdditions = new System.Windows.Forms.Panel();
            this.chkNoSubLedger = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLedgers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubLedger)).BeginInit();
            this.panelAdditions.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Red;
            this.autoLabel1.Location = new System.Drawing.Point(609, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(209, 29);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Opening Balance";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.Location = new System.Drawing.Point(12, 28);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(160, 24);
            this.autoLabel2.TabIndex = 1;
            this.autoLabel2.Text = "Financial Year ?";
            // 
            // cmbFinYear
            // 
            this.cmbFinYear.DisplayMember = "FINYEAR";
            this.cmbFinYear.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbFinYear.Location = new System.Drawing.Point(178, 28);
            this.cmbFinYear.Name = "cmbFinYear";
            this.cmbFinYear.Size = new System.Drawing.Size(142, 32);
            this.cmbFinYear.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbFinYear.TabIndex = 2;
            this.cmbFinYear.ValueMember = "FINYEAR";
            // 
            // btnFetch
            // 
            this.btnFetch.AccessibleName = "Button";
            this.btnFetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFetch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnFetch.Location = new System.Drawing.Point(326, 28);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(96, 32);
            this.btnFetch.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFetch.TabIndex = 3;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = false;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // gridLedgers
            // 
            this.gridLedgers.AccessibleName = "Table";
            this.gridLedgers.AllowFiltering = true;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "Ledger ID";
            gridTextColumn1.MappingName = "LEDGERID";
            gridTextColumn1.Width = 150D;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Ledger";
            gridTextColumn2.MappingName = "LEDGER";
            gridTextColumn2.Width = 450D;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Sub Ledger ID";
            gridTextColumn3.MappingName = "SUBLEDGERID";
            gridTextColumn3.Width = 150D;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Sub Ledger";
            gridTextColumn4.MappingName = "SUBLEDGER";
            gridTextColumn4.Width = 450D;
            this.gridLedgers.Columns.Add(gridTextColumn1);
            this.gridLedgers.Columns.Add(gridTextColumn2);
            this.gridLedgers.Columns.Add(gridTextColumn3);
            this.gridLedgers.Columns.Add(gridTextColumn4);
            this.gridLedgers.Location = new System.Drawing.Point(13, 66);
            this.gridLedgers.Name = "gridLedgers";
            this.gridLedgers.PreviewRowHeight = 35;
            this.gridLedgers.ShowGroupDropArea = true;
            this.gridLedgers.Size = new System.Drawing.Size(1325, 391);
            this.gridLedgers.TabIndex = 4;
            this.gridLedgers.Text = "sfDataGrid1";
            // 
            // lblLedger
            // 
            this.lblLedger.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLedger.Location = new System.Drawing.Point(281, 24);
            this.lblLedger.Name = "lblLedger";
            this.lblLedger.Size = new System.Drawing.Size(88, 24);
            this.lblLedger.TabIndex = 5;
            this.lblLedger.Text = "Ledger  ";
            // 
            // cmbLedger
            // 
            this.cmbLedger.DisplayMember = "LEDGER";
            this.cmbLedger.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbLedger.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLedger.Location = new System.Drawing.Point(358, 16);
            this.cmbLedger.Name = "cmbLedger";
            this.cmbLedger.Size = new System.Drawing.Size(794, 32);
            this.cmbLedger.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLedger.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLedger.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbLedger.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLedger.TabIndex = 6;
            this.cmbLedger.ValueMember = "LEDGERCODE";
            // 
            // btnFetchSubLedger
            // 
            this.btnFetchSubLedger.AccessibleName = "Button";
            this.btnFetchSubLedger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFetchSubLedger.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnFetchSubLedger.ForeColor = System.Drawing.Color.White;
            this.btnFetchSubLedger.Location = new System.Drawing.Point(1158, 16);
            this.btnFetchSubLedger.Name = "btnFetchSubLedger";
            this.btnFetchSubLedger.Size = new System.Drawing.Size(85, 32);
            this.btnFetchSubLedger.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFetchSubLedger.Style.ForeColor = System.Drawing.Color.White;
            this.btnFetchSubLedger.TabIndex = 7;
            this.btnFetchSubLedger.Text = "Fetch";
            this.btnFetchSubLedger.UseVisualStyleBackColor = false;
            this.btnFetchSubLedger.Click += new System.EventHandler(this.btnFetchSubLedger_Click);
            // 
            // lblSubLedger
            // 
            this.lblSubLedger.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubLedger.Location = new System.Drawing.Point(278, 92);
            this.lblSubLedger.Name = "lblSubLedger";
            this.lblSubLedger.Size = new System.Drawing.Size(130, 24);
            this.lblSubLedger.TabIndex = 8;
            this.lblSubLedger.Text = "Sub Ledgers";
            // 
            // cmbSubLedger
            // 
            this.cmbSubLedger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSubLedger.DisplayMember = "SUBLEDGER";
            this.cmbSubLedger.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbSubLedger.Location = new System.Drawing.Point(409, 84);
            this.cmbSubLedger.Name = "cmbSubLedger";
            this.cmbSubLedger.Size = new System.Drawing.Size(794, 32);
            this.cmbSubLedger.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSubLedger.TabIndex = 9;
            this.cmbSubLedger.ValueMember = "SUBLEDGERCODE";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "Button";
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1226, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 32);
            this.btnAdd.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.Style.ForeColor = System.Drawing.Color.White;
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelAdditions
            // 
            this.panelAdditions.Controls.Add(this.chkNoSubLedger);
            this.panelAdditions.Controls.Add(this.cmbSubLedger);
            this.panelAdditions.Controls.Add(this.btnFetchSubLedger);
            this.panelAdditions.Controls.Add(this.btnAdd);
            this.panelAdditions.Controls.Add(this.cmbLedger);
            this.panelAdditions.Controls.Add(this.lblSubLedger);
            this.panelAdditions.Controls.Add(this.lblLedger);
            this.panelAdditions.Location = new System.Drawing.Point(13, 463);
            this.panelAdditions.Name = "panelAdditions";
            this.panelAdditions.Size = new System.Drawing.Size(1325, 122);
            this.panelAdditions.TabIndex = 13;
            // 
            // chkNoSubLedger
            // 
            this.chkNoSubLedger.AutoSize = true;
            this.chkNoSubLedger.Checked = true;
            this.chkNoSubLedger.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNoSubLedger.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNoSubLedger.Location = new System.Drawing.Point(18, 46);
            this.chkNoSubLedger.Name = "chkNoSubLedger";
            this.chkNoSubLedger.Size = new System.Drawing.Size(207, 33);
            this.chkNoSubLedger.TabIndex = 10;
            this.chkNoSubLedger.Text = "No Sub Ledger";
            this.chkNoSubLedger.UseVisualStyleBackColor = true;
            this.chkNoSubLedger.CheckedChanged += new System.EventHandler(this.chkNoSubLedger_CheckedChanged);
            // 
            // frmOpeningBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 591);
            this.Controls.Add(this.gridLedgers);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.cmbFinYear);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.panelAdditions);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOpeningBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opening Balance";
            this.Load += new System.EventHandler(this.frmOpeningBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLedgers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubLedger)).EndInit();
            this.panelAdditions.ResumeLayout(false);
            this.panelAdditions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.WinForms.ListView.SfComboBox cmbFinYear;
        private Syncfusion.WinForms.Controls.SfButton btnFetch;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridLedgers;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblLedger;
        private Syncfusion.WinForms.ListView.SfComboBox cmbLedger;
        private Syncfusion.WinForms.Controls.SfButton btnFetchSubLedger;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblSubLedger;
        private Syncfusion.WinForms.ListView.SfComboBox cmbSubLedger;
        private Syncfusion.WinForms.Controls.SfButton btnAdd;
        private System.Windows.Forms.Panel panelAdditions;
        private System.Windows.Forms.CheckBox chkNoSubLedger;
    }
}