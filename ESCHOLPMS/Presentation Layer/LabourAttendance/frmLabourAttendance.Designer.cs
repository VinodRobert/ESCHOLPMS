namespace ESCHOLPMS 
{
    partial class frmLabourAttendance
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtAttendance = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.btnFetch = new Syncfusion.WinForms.Controls.SfButton();
            this.gridAttendance = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnPost = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExport = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExtract = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Labour Attendance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Attendance Of ";
            // 
            // dtAttendance
            // 
            this.dtAttendance.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate;
            this.dtAttendance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAttendance.Location = new System.Drawing.Point(16, 61);
            this.dtAttendance.Name = "dtAttendance";
            this.dtAttendance.Size = new System.Drawing.Size(403, 34);
            this.dtAttendance.TabIndex = 2;
            // 
            // btnFetch
            // 
            this.btnFetch.AccessibleName = "Button";
            this.btnFetch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnFetch.ForeColor = System.Drawing.Color.Red;
            this.btnFetch.Location = new System.Drawing.Point(647, 61);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(96, 28);
            this.btnFetch.Style.ForeColor = System.Drawing.Color.Red;
            this.btnFetch.TabIndex = 3;
            this.btnFetch.Text = "Display";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // gridAttendance
            // 
            this.gridAttendance.AccessibleName = "Table";
            this.gridAttendance.AllowFiltering = true;
            this.gridAttendance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAttendance.Location = new System.Drawing.Point(12, 113);
            this.gridAttendance.Name = "gridAttendance";
            this.gridAttendance.PreviewRowHeight = 35;
            this.gridAttendance.Size = new System.Drawing.Size(1191, 622);
            this.gridAttendance.TabIndex = 4;
            this.gridAttendance.Text = "sfDataGrid1";
            this.gridAttendance.Click += new System.EventHandler(this.gridAttendance_Click);
            // 
            // btnPost
            // 
            this.btnPost.AccessibleName = "Button";
            this.btnPost.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPost.Location = new System.Drawing.Point(813, 61);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(131, 28);
            this.btnPost.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPost.TabIndex = 5;
            this.btnPost.Text = "Edit and Post ";
            this.btnPost.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExport
            // 
            this.btnExport.AccessibleName = "Button";
            this.btnExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnExport.Location = new System.Drawing.Point(1013, 61);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(96, 28);
            this.btnExport.Style.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Detail";
            // 
            // btnExtract
            // 
            this.btnExtract.AccessibleName = "Button";
            this.btnExtract.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnExtract.ForeColor = System.Drawing.Color.Blue;
            this.btnExtract.Location = new System.Drawing.Point(493, 61);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(96, 28);
            this.btnExtract.Style.ForeColor = System.Drawing.Color.Blue;
            this.btnExtract.TabIndex = 7;
            this.btnExtract.Text = "Fetch";
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // frmLabourAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 747);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.gridAttendance);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.dtAttendance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLabourAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labour Attendance";
            this.Load += new System.EventHandler(this.frmLabourAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtAttendance;
        private Syncfusion.WinForms.Controls.SfButton btnFetch;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridAttendance;
        private Syncfusion.WinForms.Controls.SfButton btnPost;
        private Syncfusion.WinForms.Controls.SfButton btnExport;
        private Syncfusion.WinForms.Controls.SfButton btnExtract;
    }
}