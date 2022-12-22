namespace ESCHOLPMS 
{
    partial class frmAttendanceOfTheDay
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
            this.btnView = new System.Windows.Forms.Button();
            this.label3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dtStartDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.gridHistory = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.lable2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.cmbAccessPoint = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblFetch = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccessPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(639, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check In  Of The Day";
            // 
            // btnView
            // 
            this.btnView.Enabled = false;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Blue;
            this.btnView.Location = new System.Drawing.Point(1321, 95);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(119, 34);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(184, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Check In Details Of Site :";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Location = new System.Drawing.Point(999, 94);
            this.dtStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(317, 34);
            this.dtStartDate.TabIndex = 4;
            // 
            // gridHistory
            // 
            this.gridHistory.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridHistory.BackColor = System.Drawing.SystemColors.Window;
            this.gridHistory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridHistory.Location = new System.Drawing.Point(24, 150);
            this.gridHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridHistory.Size = new System.Drawing.Size(1415, 510);
            this.gridHistory.TabIndex = 9;
            this.gridHistory.Text = "gridGroupingControl1";
            this.gridHistory.UseRightToLeftCompatibleTextBox = true;
            this.gridHistory.VersionInfo = "19.2460.0.44";
            this.gridHistory.TableControlDrawCellDisplayText += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlDrawCellDisplayTextEventHandler(this.gridHistory_TableControlDrawCellDisplayText_1);
            this.gridHistory.FilterBarSelectedItemChanged += new Syncfusion.Windows.Forms.Grid.Grouping.FilterBarSelectedItemChangedEventHandler(this.gridHistory_FilterBarSelectedItemChanged_1);
            // 
            // lable2
            // 
            this.lable2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lable2.Location = new System.Drawing.Point(24, 110);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(65, 19);
            this.lable2.TabIndex = 16;
            this.lable2.Text = "Step 2:";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel3.Location = new System.Drawing.Point(24, 62);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(65, 19);
            this.autoLabel3.TabIndex = 17;
            this.autoLabel3.Text = "Step 1:";
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.Blue;
            this.autoLabel4.Location = new System.Drawing.Point(184, 62);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(307, 19);
            this.autoLabel4.TabIndex = 18;
            this.autoLabel4.Text = "Download Details From Spintly Server";
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDownLoad.Location = new System.Drawing.Point(610, 55);
            this.btnDownLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(119, 34);
            this.btnDownLoad.TabIndex = 19;
            this.btnDownLoad.Text = "Start";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // cmbAccessPoint
            // 
            this.cmbAccessPoint.DisplayMember = "ACCESSPOINTNAME";
            this.cmbAccessPoint.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbAccessPoint.Enabled = false;
            this.cmbAccessPoint.Location = new System.Drawing.Point(429, 95);
            this.cmbAccessPoint.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAccessPoint.Name = "cmbAccessPoint";
            this.cmbAccessPoint.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.cmbAccessPoint.Size = new System.Drawing.Size(521, 34);
            this.cmbAccessPoint.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbAccessPoint.TabIndex = 20;
            this.cmbAccessPoint.ValueMember = "SPINTLYACCESSPOINTID";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(957, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "On";
            // 
            // lblFetch
            // 
            this.lblFetch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFetch.ForeColor = System.Drawing.Color.SlateGray;
            this.lblFetch.Location = new System.Drawing.Point(735, 62);
            this.lblFetch.Name = "lblFetch";
            this.lblFetch.Size = new System.Drawing.Size(530, 19);
            this.lblFetch.TabIndex = 22;
            this.lblFetch.Text = "Fetch and Download in Progress. Wait Till Start Button Disabled !!";
            this.lblFetch.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExport.Location = new System.Drawing.Point(1320, 55);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(119, 34);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Enabled = false;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPDF.Location = new System.Drawing.Point(1320, 17);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(119, 34);
            this.btnPDF.TabIndex = 24;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // frmAttendanceOfTheDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 688);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblFetch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbAccessPoint);
            this.Controls.Add(this.btnDownLoad);
            this.Controls.Add(this.autoLabel4);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.gridHistory);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAttendanceOfTheDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In Details Of Site ";
            this.Load += new System.EventHandler(this.frmAccessHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccessPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private Syncfusion.Windows.Forms.Tools.AutoLabel label3;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtStartDate;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridHistory;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lable2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private System.Windows.Forms.Button btnDownLoad;
        private Syncfusion.WinForms.ListView.SfComboBox cmbAccessPoint;
        private Syncfusion.Windows.Forms.Tools.AutoLabel label4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblFetch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPDF;
    }
}