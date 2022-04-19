namespace ESCHOLPMS
{
    partial class frmFixTB
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
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn3 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinYear = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.btnFetch = new Syncfusion.WinForms.Controls.SfButton();
            this.gridGroupIndex = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblGroupIndex = new System.Windows.Forms.Label();
            this.txtGroupIndex = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.btnGet = new Syncfusion.WinForms.Controls.SfButton();
            this.lblDifference = new System.Windows.Forms.Label();
            this.txtDifference = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.gridDistribution = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblRowID = new System.Windows.Forms.Label();
            this.txtCorrection = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.btnUpdateLine = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSaveGroup = new Syncfusion.WinForms.Controls.SfButton();
            this.panelCorrection = new System.Windows.Forms.Panel();
            this.lblCorrection = new System.Windows.Forms.Label();
            this.txtRowID = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribution)).BeginInit();
            this.panelCorrection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRowID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(633, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fix The Trial Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Financial Year ?";
            // 
            // txtFinYear
            // 
            this.txtFinYear.BeforeTouchSize = new System.Drawing.Size(100, 28);
            this.txtFinYear.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinYear.IntegerValue = ((long)(2021));
            this.txtFinYear.Location = new System.Drawing.Point(145, 58);
            this.txtFinYear.Name = "txtFinYear";
            this.txtFinYear.NumberGroupSeparator = "";
            this.txtFinYear.Size = new System.Drawing.Size(100, 28);
            this.txtFinYear.TabIndex = 4;
            this.txtFinYear.Text = "2021";
            // 
            // btnFetch
            // 
            this.btnFetch.AccessibleName = "Button";
            this.btnFetch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetch.Location = new System.Drawing.Point(260, 58);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(96, 28);
            this.btnFetch.TabIndex = 5;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // gridGroupIndex
            // 
            this.gridGroupIndex.AccessibleName = "Table";
            gridTextColumn1.HeaderText = "Type";
            gridTextColumn1.MappingName = "TRANSACTIONTYPEID";
            gridTextColumn1.Width = 80D;
            gridTextColumn2.HeaderText = "Index";
            gridTextColumn2.MappingName = "GROUPINDEX";
            gridTextColumn2.Width = 80D;
            gridNumericColumn1.HeaderText = "Balance";
            gridNumericColumn1.MappingName = "BALANCE";
            gridNumericColumn1.Width = 90D;
            this.gridGroupIndex.Columns.Add(gridTextColumn1);
            this.gridGroupIndex.Columns.Add(gridTextColumn2);
            this.gridGroupIndex.Columns.Add(gridNumericColumn1);
            this.gridGroupIndex.Location = new System.Drawing.Point(16, 118);
            this.gridGroupIndex.Name = "gridGroupIndex";
            this.gridGroupIndex.PreviewRowHeight = 35;
            this.gridGroupIndex.Size = new System.Drawing.Size(364, 471);
            this.gridGroupIndex.TabIndex = 6;
            this.gridGroupIndex.Text = "sfDataGrid1";
            // 
            // lblGroupIndex
            // 
            this.lblGroupIndex.AutoSize = true;
            this.lblGroupIndex.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupIndex.Location = new System.Drawing.Point(20, 12);
            this.lblGroupIndex.Name = "lblGroupIndex";
            this.lblGroupIndex.Size = new System.Drawing.Size(98, 19);
            this.lblGroupIndex.TabIndex = 7;
            this.lblGroupIndex.Text = "Group Index";
            // 
            // txtGroupIndex
            // 
            this.txtGroupIndex.BeforeTouchSize = new System.Drawing.Size(100, 28);
            this.txtGroupIndex.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupIndex.IntegerValue = ((long)(2021));
            this.txtGroupIndex.Location = new System.Drawing.Point(153, 12);
            this.txtGroupIndex.Name = "txtGroupIndex";
            this.txtGroupIndex.NumberGroupSeparator = "";
            this.txtGroupIndex.Size = new System.Drawing.Size(100, 28);
            this.txtGroupIndex.TabIndex = 8;
            this.txtGroupIndex.Text = "2021";
            // 
            // btnGet
            // 
            this.btnGet.AccessibleName = "Button";
            this.btnGet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(341, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(96, 28);
            this.btnGet.TabIndex = 9;
            this.btnGet.Text = "Get";
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifference.Location = new System.Drawing.Point(20, 59);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(86, 19);
            this.lblDifference.TabIndex = 10;
            this.lblDifference.Text = "Difference";
            // 
            // txtDifference
            // 
            this.txtDifference.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDifference.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDifference.Location = new System.Drawing.Point(153, 51);
            this.txtDifference.Name = "txtDifference";
            this.txtDifference.Size = new System.Drawing.Size(127, 27);
            this.txtDifference.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDifference.TabIndex = 11;
            // 
            // gridDistribution
            // 
            this.gridDistribution.AccessibleName = "Table";
            gridTextColumn3.HeaderText = "RowID";
            gridTextColumn3.MappingName = "RowID";
            gridTextColumn3.Width = 120D;
            gridTextColumn4.HeaderText = "Type";
            gridTextColumn4.MappingName = "VoucherType";
            gridTextColumn4.Width = 100D;
            gridTextColumn5.HeaderText = "Ledger";
            gridTextColumn5.MappingName = "Ledger";
            gridTextColumn5.Width = 300D;
            gridNumericColumn2.HeaderText = "Debit";
            gridNumericColumn2.MappingName = "Debit";
            gridNumericColumn2.Width = 100D;
            gridNumericColumn3.HeaderText = "Credit";
            gridNumericColumn3.MappingName = "Credit";
            gridNumericColumn3.Width = 100D;
            gridTextColumn6.HeaderText = "Status";
            gridTextColumn6.MappingName = "EDITSTATUS";
            gridTextColumn6.Visible = false;
            gridTextColumn6.Width = 0D;
            this.gridDistribution.Columns.Add(gridTextColumn3);
            this.gridDistribution.Columns.Add(gridTextColumn4);
            this.gridDistribution.Columns.Add(gridTextColumn5);
            this.gridDistribution.Columns.Add(gridNumericColumn2);
            this.gridDistribution.Columns.Add(gridNumericColumn3);
            this.gridDistribution.Columns.Add(gridTextColumn6);
            this.gridDistribution.Location = new System.Drawing.Point(18, 92);
            this.gridDistribution.Name = "gridDistribution";
            this.gridDistribution.PreviewRowHeight = 35;
            this.gridDistribution.Size = new System.Drawing.Size(1041, 225);
            this.gridDistribution.TabIndex = 12;
            this.gridDistribution.Text = "sfDataGrid1";
            // 
            // lblRowID
            // 
            this.lblRowID.AutoSize = true;
            this.lblRowID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowID.Location = new System.Drawing.Point(20, 343);
            this.lblRowID.Name = "lblRowID";
            this.lblRowID.Size = new System.Drawing.Size(67, 19);
            this.lblRowID.TabIndex = 13;
            this.lblRowID.Text = "Row ID ";
            // 
            // txtCorrection
            // 
            this.txtCorrection.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrection.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCorrection.Location = new System.Drawing.Point(153, 400);
            this.txtCorrection.Name = "txtCorrection";
            this.txtCorrection.Size = new System.Drawing.Size(100, 27);
            this.txtCorrection.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCorrection.TabIndex = 14;
            // 
            // btnUpdateLine
            // 
            this.btnUpdateLine.AccessibleName = "Button";
            this.btnUpdateLine.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLine.Location = new System.Drawing.Point(329, 400);
            this.btnUpdateLine.Name = "btnUpdateLine";
            this.btnUpdateLine.Size = new System.Drawing.Size(220, 28);
            this.btnUpdateLine.TabIndex = 15;
            this.btnUpdateLine.Text = "Update and ReCompute";
            this.btnUpdateLine.Click += new System.EventHandler(this.btnUpdateLine_Click);
            // 
            // btnSaveGroup
            // 
            this.btnSaveGroup.AccessibleName = "Button";
            this.btnSaveGroup.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGroup.Location = new System.Drawing.Point(926, 429);
            this.btnSaveGroup.Name = "btnSaveGroup";
            this.btnSaveGroup.Size = new System.Drawing.Size(120, 28);
            this.btnSaveGroup.TabIndex = 16;
            this.btnSaveGroup.Text = "Save Group";
            this.btnSaveGroup.Click += new System.EventHandler(this.btnSaveGroup_Click);
            // 
            // panelCorrection
            // 
            this.panelCorrection.Controls.Add(this.lblCorrection);
            this.panelCorrection.Controls.Add(this.txtRowID);
            this.panelCorrection.Controls.Add(this.btnSaveGroup);
            this.panelCorrection.Controls.Add(this.lblGroupIndex);
            this.panelCorrection.Controls.Add(this.btnUpdateLine);
            this.panelCorrection.Controls.Add(this.txtGroupIndex);
            this.panelCorrection.Controls.Add(this.txtCorrection);
            this.panelCorrection.Controls.Add(this.lblRowID);
            this.panelCorrection.Controls.Add(this.btnGet);
            this.panelCorrection.Controls.Add(this.txtDifference);
            this.panelCorrection.Controls.Add(this.gridDistribution);
            this.panelCorrection.Controls.Add(this.lblDifference);
            this.panelCorrection.Location = new System.Drawing.Point(386, 118);
            this.panelCorrection.Name = "panelCorrection";
            this.panelCorrection.Size = new System.Drawing.Size(1062, 471);
            this.panelCorrection.TabIndex = 17;
            // 
            // lblCorrection
            // 
            this.lblCorrection.AutoSize = true;
            this.lblCorrection.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrection.Location = new System.Drawing.Point(20, 400);
            this.lblCorrection.Name = "lblCorrection";
            this.lblCorrection.Size = new System.Drawing.Size(91, 19);
            this.lblCorrection.TabIndex = 18;
            this.lblCorrection.Text = "Correction ";
            // 
            // txtRowID
            // 
            this.txtRowID.BeforeTouchSize = new System.Drawing.Size(100, 28);
            this.txtRowID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRowID.IntegerValue = ((long)(2021));
            this.txtRowID.Location = new System.Drawing.Point(153, 343);
            this.txtRowID.Name = "txtRowID";
            this.txtRowID.NumberGroupSeparator = "";
            this.txtRowID.Size = new System.Drawing.Size(100, 28);
            this.txtRowID.TabIndex = 17;
            this.txtRowID.Text = "2021";
            // 
            // frmFixTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 601);
            this.Controls.Add(this.gridGroupIndex);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.txtFinYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelCorrection);
            this.Name = "frmFixTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fix Your TB";
            this.Load += new System.EventHandler(this.frmFixTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFinYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribution)).EndInit();
            this.panelCorrection.ResumeLayout(false);
            this.panelCorrection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRowID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtFinYear;
        private Syncfusion.WinForms.Controls.SfButton btnFetch;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridGroupIndex;
        private System.Windows.Forms.Label lblGroupIndex;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtGroupIndex;
        private Syncfusion.WinForms.Controls.SfButton btnGet;
        private System.Windows.Forms.Label lblDifference;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtDifference;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridDistribution;
        private System.Windows.Forms.Label lblRowID;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtCorrection;
        private Syncfusion.WinForms.Controls.SfButton btnUpdateLine;
        private Syncfusion.WinForms.Controls.SfButton btnSaveGroup;
        private System.Windows.Forms.Panel panelCorrection;
        private System.Windows.Forms.Label lblCorrection;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtRowID;
    }
}