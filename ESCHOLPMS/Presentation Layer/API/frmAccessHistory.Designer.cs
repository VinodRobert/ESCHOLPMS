namespace ESCHOLPMS 
{
    partial class frmAccessHistory
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
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbAccessPoint = new Syncfusion.WinForms.ListView.SfComboBox();
            this.gridHistory = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.cmbUsers = new Syncfusion.WinForms.ListView.SfComboBox();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.rdWorker = new System.Windows.Forms.RadioButton();
            this.rdStaff = new System.Windows.Forms.RadioButton();
            this.rdBoth = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccessPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(619, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Access History";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(1190, 62);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(119, 39);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(24, 44);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(57, 19);
            this.autoLabel1.TabIndex = 3;
            this.autoLabel1.Text = "Period";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Location = new System.Drawing.Point(24, 67);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(317, 34);
            this.dtStartDate.TabIndex = 4;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Location = new System.Drawing.Point(356, 67);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(317, 34);
            this.dtEndDate.TabIndex = 5;
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.Location = new System.Drawing.Point(24, 114);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(113, 19);
            this.autoLabel2.TabIndex = 7;
            this.autoLabel2.Text = "Access Points";
            // 
            // cmbAccessPoint
            // 
            this.cmbAccessPoint.DisplayMember = "ACCESSPOINT";
            this.cmbAccessPoint.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbAccessPoint.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessPoint.Location = new System.Drawing.Point(24, 136);
            this.cmbAccessPoint.Name = "cmbAccessPoint";
            this.cmbAccessPoint.Size = new System.Drawing.Size(649, 32);
            this.cmbAccessPoint.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessPoint.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessPoint.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbAccessPoint.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessPoint.TabIndex = 8;
            this.cmbAccessPoint.ValueMember = "SPINTLYACCESSPOINTID";
            // 
            // gridHistory
            // 
            this.gridHistory.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridHistory.BackColor = System.Drawing.SystemColors.Window;
            this.gridHistory.Location = new System.Drawing.Point(24, 235);
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridHistory.Size = new System.Drawing.Size(1285, 425);
            this.gridHistory.TabIndex = 9;
            this.gridHistory.Text = "gridGroupingControl1";
            this.gridHistory.UseRightToLeftCompatibleTextBox = true;
            this.gridHistory.VersionInfo = "19.2460.0.44";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DisplayMember = "NAME";
            this.cmbUsers.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cmbUsers.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsers.Location = new System.Drawing.Point(24, 188);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(649, 32);
            this.cmbUsers.Style.EditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsers.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsers.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbUsers.Style.TokenStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsers.TabIndex = 10;
            this.cmbUsers.ValueMember = "SPINTLYID";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.Location = new System.Drawing.Point(24, 171);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(43, 19);
            this.autoLabel3.TabIndex = 11;
            this.autoLabel3.Text = "User";
            // 
            // rdWorker
            // 
            this.rdWorker.AutoSize = true;
            this.rdWorker.Location = new System.Drawing.Point(922, 67);
            this.rdWorker.Name = "rdWorker";
            this.rdWorker.Size = new System.Drawing.Size(75, 21);
            this.rdWorker.TabIndex = 12;
            this.rdWorker.TabStop = true;
            this.rdWorker.Text = "Worker";
            this.rdWorker.UseVisualStyleBackColor = true;
            this.rdWorker.CheckedChanged += new System.EventHandler(this.rdWorker_CheckedChanged);
            // 
            // rdStaff
            // 
            this.rdStaff.AutoSize = true;
            this.rdStaff.Location = new System.Drawing.Point(922, 114);
            this.rdStaff.Name = "rdStaff";
            this.rdStaff.Size = new System.Drawing.Size(58, 21);
            this.rdStaff.TabIndex = 13;
            this.rdStaff.TabStop = true;
            this.rdStaff.Text = "Staff";
            this.rdStaff.UseVisualStyleBackColor = true;
            this.rdStaff.CheckedChanged += new System.EventHandler(this.rdStaff_CheckedChanged);
            // 
            // rdBoth
            // 
            this.rdBoth.AutoSize = true;
            this.rdBoth.Location = new System.Drawing.Point(922, 171);
            this.rdBoth.Name = "rdBoth";
            this.rdBoth.Size = new System.Drawing.Size(58, 21);
            this.rdBoth.TabIndex = 14;
            this.rdBoth.TabStop = true;
            this.rdBoth.Text = "Both";
            this.rdBoth.UseVisualStyleBackColor = true;
            this.rdBoth.CheckedChanged += new System.EventHandler(this.rdBoth_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1190, 129);
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
            this.ClientSize = new System.Drawing.Size(1343, 688);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.rdBoth);
            this.Controls.Add(this.rdStaff);
            this.Controls.Add(this.rdWorker);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.gridHistory);
            this.Controls.Add(this.cmbAccessPoint);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Name = "frmAccessHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API | Access History";
            this.Load += new System.EventHandler(this.frmAccessHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccessPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtStartDate;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtEndDate;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.WinForms.ListView.SfComboBox cmbAccessPoint;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridHistory;
        private Syncfusion.WinForms.ListView.SfComboBox cmbUsers;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private System.Windows.Forms.RadioButton rdWorker;
        private System.Windows.Forms.RadioButton rdStaff;
        private System.Windows.Forms.RadioButton rdBoth;
        private System.Windows.Forms.Button btnReset;
    }
}