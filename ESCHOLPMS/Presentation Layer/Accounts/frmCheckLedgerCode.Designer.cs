namespace ESCHOLPMS 
{
    partial class frmCheckLedgerCode
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.gridEmpty = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblResult = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check Missing Ledger Codes";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(31, 109);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(146, 40);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check Now ?";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // gridEmpty
            // 
            this.gridEmpty.AccessibleName = "Table";
            this.gridEmpty.Location = new System.Drawing.Point(31, 230);
            this.gridEmpty.Name = "gridEmpty";
            this.gridEmpty.PreviewRowHeight = 35;
            this.gridEmpty.Size = new System.Drawing.Size(707, 150);
            this.gridEmpty.TabIndex = 2;
            this.gridEmpty.Text = "sfDataGrid1";
            this.gridEmpty.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(31, 183);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(14, 19);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = ".";
            // 
            // frmCheckLedgerCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.gridEmpty);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label1);
            this.Name = "frmCheckLedgerCode";
            this.Text = "Check Missing Ledger Codes";
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridEmpty;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblResult;
    }
}