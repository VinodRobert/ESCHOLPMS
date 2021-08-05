namespace ESCHOLPMS
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSalaryMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryPrepartionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postToAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripLoginName = new Syncfusion.Windows.Forms.Tools.StatusStripLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripProjectName = new Syncfusion.Windows.Forms.Tools.StatusStripLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.menuRegistration,
            this.menuAttendance,
            this.salaryToolStripMenuItem,
            this.menuReports});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(1422, 31);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MenuStrip";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentToolStripMenuItem,
            this.designationToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // designationToolStripMenuItem
            // 
            this.designationToolStripMenuItem.Name = "designationToolStripMenuItem";
            this.designationToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.designationToolStripMenuItem.Text = "Designation";
            // 
            // menuRegistration
            // 
            this.menuRegistration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.toolStripSeparator1,
            this.workersToolStripMenuItem});
            this.menuRegistration.Name = "menuRegistration";
            this.menuRegistration.Size = new System.Drawing.Size(120, 27);
            this.menuRegistration.Text = "Registration";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(153, 28);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // workersToolStripMenuItem
            // 
            this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
            this.workersToolStripMenuItem.Size = new System.Drawing.Size(153, 28);
            this.workersToolStripMenuItem.Text = "Workers";
            // 
            // menuAttendance
            // 
            this.menuAttendance.Name = "menuAttendance";
            this.menuAttendance.Size = new System.Drawing.Size(114, 27);
            this.menuAttendance.Text = "Attendance";
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSalaryMonthToolStripMenuItem,
            this.salaryPrepartionToolStripMenuItem,
            this.splitSalaryToolStripMenuItem,
            this.postToAccountsToolStripMenuItem});
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.salaryToolStripMenuItem.Text = "Salary";
            // 
            // setSalaryMonthToolStripMenuItem
            // 
            this.setSalaryMonthToolStripMenuItem.Name = "setSalaryMonthToolStripMenuItem";
            this.setSalaryMonthToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.setSalaryMonthToolStripMenuItem.Text = "Set Salary Month";
            // 
            // salaryPrepartionToolStripMenuItem
            // 
            this.salaryPrepartionToolStripMenuItem.Name = "salaryPrepartionToolStripMenuItem";
            this.salaryPrepartionToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.salaryPrepartionToolStripMenuItem.Text = "Salary Prepartion";
            // 
            // splitSalaryToolStripMenuItem
            // 
            this.splitSalaryToolStripMenuItem.Name = "splitSalaryToolStripMenuItem";
            this.splitSalaryToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.splitSalaryToolStripMenuItem.Text = "Split Salary";
            // 
            // postToAccountsToolStripMenuItem
            // 
            this.postToAccountsToolStripMenuItem.Name = "postToAccountsToolStripMenuItem";
            this.postToAccountsToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.postToAccountsToolStripMenuItem.Text = "Post To Accounts";
            // 
            // menuReports
            // 
            this.menuReports.Name = "menuReports";
            this.menuReports.Size = new System.Drawing.Size(84, 27);
            this.menuReports.Text = "Reports";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLoginName,
            this.toolStripStatusLabel,
            this.stripProjectName});
            this.statusStrip.Location = new System.Drawing.Point(0, 825);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1422, 28);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // stripLoginName
            // 
            this.stripLoginName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripLoginName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stripLoginName.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.stripLoginName.Name = "stripLoginName";
            this.stripLoginName.Size = new System.Drawing.Size(107, 23);
            this.stripLoginName.Text = "Login Name";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 23);
            this.toolStripStatusLabel.Text = "Status";
            this.toolStripStatusLabel.Visible = false;
            // 
            // stripProjectName
            // 
            this.stripProjectName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripProjectName.ForeColor = System.Drawing.Color.Blue;
            this.stripProjectName.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.stripProjectName.Name = "stripProjectName";
            this.stripProjectName.Size = new System.Drawing.Size(125, 23);
            this.stripProjectName.Text = "Prroject Name";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 853);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESCHOL | Access Control System | HR";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private Syncfusion.Windows.Forms.Tools.StatusStripLabel stripLoginName;
        private Syncfusion.Windows.Forms.Tools.StatusStripLabel stripProjectName;
        private System.Windows.Forms.ToolStripMenuItem menuRegistration;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAttendance;
        private System.Windows.Forms.ToolStripMenuItem menuReports;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSalaryMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryPrepartionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postToAccountsToolStripMenuItem;
    }
}



