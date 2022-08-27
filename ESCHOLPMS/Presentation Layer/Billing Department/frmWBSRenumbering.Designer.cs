namespace ESCHOLPMS 
{
    partial class frmWBSRenumbering
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
            this.cmbProjects = new Syncfusion.WinForms.ListView.SfComboBox();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnFetch = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.gridWBS = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.lblAlert = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWBS)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Red;
            this.autoLabel1.Location = new System.Drawing.Point(443, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(281, 24);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Work Break Down Structure ";
            // 
            // cmbProjects
            // 
            this.cmbProjects.DisplayMember = "PROJECTNAME";
            this.cmbProjects.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbProjects.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjects.Location = new System.Drawing.Point(111, 53);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(655, 32);
            this.cmbProjects.Style.EditorStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjects.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjects.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProjects.Style.TokenStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjects.TabIndex = 1;
            this.cmbProjects.Text = "Select Project";
            this.cmbProjects.ValueMember = "COSTCENTREID";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel2.Location = new System.Drawing.Point(12, 53);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(80, 19);
            this.autoLabel2.TabIndex = 2;
            this.autoLabel2.Text = "Project ?";
            // 
            // btnFetch
            // 
            this.btnFetch.AccessibleName = "Button";
            this.btnFetch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnFetch.ForeColor = System.Drawing.Color.Red;
            this.btnFetch.Location = new System.Drawing.Point(835, 57);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(111, 28);
            this.btnFetch.Style.ForeColor = System.Drawing.Color.Red;
            this.btnFetch.TabIndex = 3;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.Blue;
            this.btnClose.Location = new System.Drawing.Point(1013, 57);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 28);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close\'";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridWBS
            // 
            this.gridWBS.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridWBS.BackColor = System.Drawing.SystemColors.Window;
            this.gridWBS.Location = new System.Drawing.Point(12, 125);
            this.gridWBS.Name = "gridWBS";
            this.gridWBS.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridWBS.Size = new System.Drawing.Size(1137, 661);
            this.gridWBS.TabIndex = 5;
            this.gridWBS.Text = "gridGroupingControl1";
            this.gridWBS.UseRightToLeftCompatibleTextBox = true;
            this.gridWBS.VersionInfo = "20.1460.0.47";
            this.gridWBS.QueryCellStyleInfo += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventHandler(this.gridWBS_QueryCellStyleInfo);
            // 
            // lblAlert
            // 
            this.lblAlert.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAlert.Location = new System.Drawing.Point(595, 103);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(340, 19);
            this.lblAlert.TabIndex = 6;
            this.lblAlert.Text = "Put Appropriate Dispaly Order and Submit";
            // 
            // frmWBSRenumbering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 782);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.gridWBS);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.autoLabel1);
            this.Name = "frmWBSRenumbering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Re-Number WBS List";
            this.Load += new System.EventHandler(this.frmWBSRenumbering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.ListView.SfComboBox cmbProjects;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.WinForms.Controls.SfButton btnFetch;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridWBS;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblAlert;
    }
}