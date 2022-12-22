namespace ESCHOLPMS 
{
    partial class frmAttendnaceOfTheDay
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dtStartDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtEndDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.gridHistory = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(639, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Access History";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(709, 31);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(119, 34);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(24, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(57, 19);
            this.autoLabel1.TabIndex = 3;
            this.autoLabel1.Text = "Period";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Location = new System.Drawing.Point(24, 31);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(317, 34);
            this.dtStartDate.TabIndex = 4;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Location = new System.Drawing.Point(366, 31);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(317, 34);
            this.dtEndDate.TabIndex = 5;
            // 
            // gridHistory
            // 
            this.gridHistory.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridHistory.BackColor = System.Drawing.SystemColors.Window;
            this.gridHistory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridHistory.Location = new System.Drawing.Point(24, 82);
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridHistory.Size = new System.Drawing.Size(1416, 578);
            this.gridHistory.TabIndex = 9;
            this.gridHistory.Text = "gridGroupingControl1";
            this.gridHistory.UseRightToLeftCompatibleTextBox = true;
            this.gridHistory.VersionInfo = "19.2460.0.44";
            this.gridHistory.TableControlDrawCellDisplayText += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlDrawCellDisplayTextEventHandler(this.gridHistory_TableControlDrawCellDisplayText_1);
            this.gridHistory.FilterBarSelectedItemChanged += new Syncfusion.Windows.Forms.Grid.Grouping.FilterBarSelectedItemChangedEventHandler(this.gridHistory_FilterBarSelectedItemChanged_1);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1321, 26);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 39);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmAccessHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 688);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gridHistory);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Name = "frmAccessHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API | Access History";
            this.Load += new System.EventHandler(this.frmAccessHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtStartDate;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtEndDate;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridHistory;
        private System.Windows.Forms.Button btnReset;
    }
}