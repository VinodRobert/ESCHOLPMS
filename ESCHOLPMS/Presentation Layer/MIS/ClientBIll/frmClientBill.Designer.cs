namespace ESCHOLPMS 
{
    partial class frmClientBill
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
            this.cmbProjects = new Syncfusion.WinForms.ListView.SfComboBox();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnFetch = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbClientBIll = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnLoad = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbReports = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnView = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExcel = new Syncfusion.WinForms.Controls.SfButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridGeneral = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.gridTripizoidal = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.gridSteel = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClientBIll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReports)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTripizoidal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSteel)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProjects
            // 
            this.cmbProjects.DisplayMember = "PROJECTNAME";
            this.cmbProjects.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbProjects.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjects.Location = new System.Drawing.Point(12, 49);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(489, 32);
            this.cmbProjects.Style.EditorStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjects.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjects.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProjects.Style.TokenStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjects.TabIndex = 0;
            this.cmbProjects.ValueMember = "COSTCENTREID";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Red;
            this.autoLabel1.Location = new System.Drawing.Point(633, -2);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(145, 29);
            this.autoLabel1.TabIndex = 1;
            this.autoLabel1.Text = "Client BIll";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.Location = new System.Drawing.Point(12, 29);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(124, 20);
            this.autoLabel2.TabIndex = 2;
            this.autoLabel2.Text = "Project Name";
            // 
            // btnFetch
            // 
            this.btnFetch.AccessibleName = "Button";
            this.btnFetch.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetch.ForeColor = System.Drawing.Color.Blue;
            this.btnFetch.Location = new System.Drawing.Point(1234, 53);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(184, 28);
            this.btnFetch.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnFetch.TabIndex = 3;
            this.btnFetch.Text = "Fetch Bills";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.Location = new System.Drawing.Point(517, 28);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(95, 20);
            this.autoLabel3.TabIndex = 4;
            this.autoLabel3.Text = "Client BIll";
            // 
            // cmbClientBIll
            // 
            this.cmbClientBIll.DisplayMember = "BILLNUMBER";
            this.cmbClientBIll.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbClientBIll.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientBIll.Location = new System.Drawing.Point(517, 51);
            this.cmbClientBIll.Name = "cmbClientBIll";
            this.cmbClientBIll.Size = new System.Drawing.Size(338, 32);
            this.cmbClientBIll.Style.EditorStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientBIll.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientBIll.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbClientBIll.Style.TokenStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientBIll.TabIndex = 5;
            this.cmbClientBIll.ValueMember = "CLIENTBILLHEADERCODE";
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleName = "Button";
            this.btnLoad.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Blue;
            this.btnLoad.Location = new System.Drawing.Point(1234, 55);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(179, 28);
            this.btnLoad.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load Reports";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.Location = new System.Drawing.Point(861, 28);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(75, 20);
            this.autoLabel4.TabIndex = 7;
            this.autoLabel4.Text = "Reports";
            // 
            // cmbReports
            // 
            this.cmbReports.DisplayMember = "ReportName";
            this.cmbReports.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbReports.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReports.Location = new System.Drawing.Point(861, 51);
            this.cmbReports.Name = "cmbReports";
            this.cmbReports.Size = new System.Drawing.Size(359, 32);
            this.cmbReports.Style.EditorStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReports.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReports.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbReports.Style.TokenStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReports.TabIndex = 8;
            this.cmbReports.ValueMember = "ReportID";
            // 
            // btnView
            // 
            this.btnView.AccessibleName = "Button";
            this.btnView.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Blue;
            this.btnView.Location = new System.Drawing.Point(1226, 46);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(179, 37);
            this.btnView.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View Report";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.AccessibleName = "Button";
            this.btnExcel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcel.Location = new System.Drawing.Point(13, 97);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(96, 28);
            this.btnExcel.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcel.TabIndex = 11;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridSteel);
            this.panel1.Controls.Add(this.gridTripizoidal);
            this.panel1.Controls.Add(this.gridGeneral);
            this.panel1.Location = new System.Drawing.Point(13, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 507);
            this.panel1.TabIndex = 12;
            // 
            // gridGeneral
            // 
            this.gridGeneral.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridGeneral.BackColor = System.Drawing.SystemColors.Window;
            this.gridGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGeneral.Location = new System.Drawing.Point(0, 0);
            this.gridGeneral.Name = "gridGeneral";
            this.gridGeneral.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridGeneral.Size = new System.Drawing.Size(1400, 507);
            this.gridGeneral.TabIndex = 0;
            this.gridGeneral.Text = "gridGroupingControl1";
            this.gridGeneral.UseRightToLeftCompatibleTextBox = true;
            this.gridGeneral.VersionInfo = "19.2460.0.44";
            // 
            // gridTripizoidal
            // 
            this.gridTripizoidal.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridTripizoidal.BackColor = System.Drawing.SystemColors.Window;
            this.gridTripizoidal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTripizoidal.Location = new System.Drawing.Point(0, 0);
            this.gridTripizoidal.Name = "gridTripizoidal";
            this.gridTripizoidal.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridTripizoidal.Size = new System.Drawing.Size(1400, 507);
            this.gridTripizoidal.TabIndex = 1;
            this.gridTripizoidal.Text = "gridGroupingControl1";
            this.gridTripizoidal.UseRightToLeftCompatibleTextBox = true;
            this.gridTripizoidal.VersionInfo = "19.2460.0.44";
            // 
            // gridSteel
            // 
            this.gridSteel.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridSteel.BackColor = System.Drawing.SystemColors.Window;
            this.gridSteel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSteel.Location = new System.Drawing.Point(0, 0);
            this.gridSteel.Name = "gridSteel";
            this.gridSteel.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridSteel.Size = new System.Drawing.Size(1400, 507);
            this.gridSteel.TabIndex = 2;
            this.gridSteel.Text = "gridGroupingControl1";
            this.gridSteel.UseRightToLeftCompatibleTextBox = true;
            this.gridSteel.VersionInfo = "19.2460.0.44";
            // 
            // frmClientBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.cmbReports);
            this.Controls.Add(this.autoLabel4);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cmbClientBIll);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.cmbProjects);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmClientBill";
            this.Text = "Client Bill";
            this.Load += new System.EventHandler(this.frmClientBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClientBIll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReports)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTripizoidal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSteel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.ListView.SfComboBox cmbProjects;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.WinForms.Controls.SfButton btnFetch;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.WinForms.ListView.SfComboBox cmbClientBIll;
        private Syncfusion.WinForms.Controls.SfButton btnLoad;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.WinForms.ListView.SfComboBox cmbReports;
        private Syncfusion.WinForms.Controls.SfButton btnView;
        private Syncfusion.WinForms.Controls.SfButton btnExcel;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridTripizoidal;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGeneral;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridSteel;
    }
}