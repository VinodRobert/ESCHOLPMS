namespace ESCHOLPMS 
{
    partial class frmEshcolLogins
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gridList = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.btnNewLogin = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(583, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eshcol - Logins";
            // 
            // gridList
            // 
            this.gridList.AccessibleName = "Table";
            this.gridList.AllowFiltering = true;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "Status";
            gridTextColumn1.MappingName = "PROJECTSTATUS";
            gridTextColumn1.Width = 120D;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Company Name";
            gridTextColumn2.MappingName = "COMPANYNAME";
            gridTextColumn2.Width = 250D;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "Cost Centre";
            gridTextColumn3.MappingName = "COSTCENTRE";
            gridTextColumn3.Width = 250D;
            gridTextColumn4.AllowFiltering = true;
            gridTextColumn4.HeaderText = "Project Name";
            gridTextColumn4.MappingName = "PROJECTNAME";
            gridTextColumn4.Width = 250D;
            gridTextColumn5.AllowFiltering = true;
            gridTextColumn5.HeaderText = "Login Name";
            gridTextColumn5.MappingName = "USERNAME";
            gridTextColumn5.Width = 250D;
            gridTextColumn6.AllowFiltering = true;
            gridTextColumn6.HeaderText = "Role Name";
            gridTextColumn6.MappingName = "ROLENAME";
            gridTextColumn6.Width = 200D;
            this.gridList.Columns.Add(gridTextColumn1);
            this.gridList.Columns.Add(gridTextColumn2);
            this.gridList.Columns.Add(gridTextColumn3);
            this.gridList.Columns.Add(gridTextColumn4);
            this.gridList.Columns.Add(gridTextColumn5);
            this.gridList.Columns.Add(gridTextColumn6);
            this.gridList.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Top;
            this.gridList.FrozenColumnCount = 5;
            this.gridList.Location = new System.Drawing.Point(12, 84);
            this.gridList.Name = "gridList";
            this.gridList.PreviewRowHeight = 35;
            this.gridList.RowHeight = 25;
            this.gridList.ShowGroupDropArea = true;
            this.gridList.Size = new System.Drawing.Size(1361, 578);
            this.gridList.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridList.Style.HeaderStyle.Font.Bold = true;
            this.gridList.Style.HeaderStyle.Font.Facename = "Arial";
            this.gridList.Style.HeaderStyle.TextColor = System.Drawing.Color.White;
            this.gridList.TabIndex = 1;
            this.gridList.Text = "sfDataGrid1";
            this.gridList.DrawCell += new Syncfusion.WinForms.DataGrid.Events.DrawCellEventHandler(this.gridList_DrawCell);
            this.gridList.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.gridList_QueryRowStyle);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1277, 50);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 28);
            this.btnClose.Style.ForeColor = System.Drawing.Color.Red;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewLogin
            // 
            this.btnNewLogin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLogin.ForeColor = System.Drawing.Color.Red;
            this.btnNewLogin.Location = new System.Drawing.Point(12, 36);
            this.btnNewLogin.Name = "btnNewLogin";
            this.btnNewLogin.Size = new System.Drawing.Size(126, 37);
            this.btnNewLogin.TabIndex = 4;
            this.btnNewLogin.Text = "New Login";
            this.btnNewLogin.UseVisualStyleBackColor = true;
            this.btnNewLogin.Click += new System.EventHandler(this.btnNewLogin_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Blue;
            this.btnRefresh.Location = new System.Drawing.Point(160, 36);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 37);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmEshcolLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 686);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNewLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridList);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEshcolLogins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eshcol - Logins";
            this.Load += new System.EventHandler(this.frmContractLabours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid gridList;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private System.Windows.Forms.Button btnNewLogin;
        private System.Windows.Forms.Button btnRefresh;
    }
}