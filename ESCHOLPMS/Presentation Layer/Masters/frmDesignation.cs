using Syncfusion.WinForms.DataGrid.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Syncfusion.WinForms.DataGrid;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Enums;


namespace ESCHOLPMS 
{
    public partial class frmDesignation : Form
    {
        Designation desig = new Designation();
        Department  dept  = new Department();
        PMS pms = new PMS();

        Int32 desigsignationCode = 0;
        string _criteria;
    
        Color oddRow = Color.Transparent;
        Color evenRow = Color.AliceBlue;

        private void ResetGrid()
        {
            this.gridDesignation.ShowRowHeader = true;
            this.gridDesignation.ClearSelection();
            this.gridDesignation.Style.RowHeaderStyle.BackColor = Color.CadetBlue;
            this.gridDesignation.Style.RowHeaderStyle.SelectionMarkerThickness = 4;
            this.gridDesignation.Style.RowHeaderStyle.SelectionMarkerColor = Color.Red;
            this.gridDesignation.Style.RowHeaderStyle.SelectionBackColor = Color.White;
            this.gridDesignation.Style.HeaderStyle.BackColor = Color.AliceBlue;
            this.gridDesignation.Style.HeaderStyle.TextColor = Color.DarkSlateBlue;
            this.gridDesignation.Style.HeaderStyle.Font.Bold = true;
            this.gridDesignation.SelectionMode = GridSelectionMode.Single;
            this.gridDesignation.ThemeName = "Office2019Colorful";
            this.gridDesignation.TableControl.HorizontalScrollBarVisible = true;
            this.gridDesignation.TableControl.VerticalScrollBarVisible = true;
            this.gridDesignation.TableControl.HorizontalScroll.Enabled = true;
        }

        private void ClearScreen()
        {
            txtDesignationName.Text = "";
            txtHierarchyOrder.Value = 0;
            desigsignationCode = 0;
            btnAdd.Text = "Save";
            
            gridDesignation.Visible = false;
        }


        public frmDesignation()
        {
            InitializeComponent();
            gridDesignation.QueryRowStyle += gridDepartment_QueryRowStyle;
        }

        private void LoadDepartment()
        {
            DataSet dsDepartment = pms.fetchDepartment();
            cmbDepartment.DataSource = dsDepartment.Tables[0];
            cmbDepartment.Text = "Select Department";
            cmbDepartment.Refresh();
        }


        private void frmDepartment_Load(object sender, EventArgs e)
        {
            ClearScreen();
            txtDesignationName.Enabled = false;
            LoadDepartment();
        }

        private void gridDepartment_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = evenRow;
            else
                e.Style.BackColor = oddRow;
        }


        private void gridDepartment_CellClick(object sender, CellClickEventArgs e)
        {
            int rowindex = e.DataRow.Index-1;
            if (rowindex < 0)
                return;
            var record = this.gridDesignation.View.Records.GetItemAt(rowindex);
            string designationCodeString = record.GetType().GetProperty("DesignationCode").GetValue(record).ToString();
            string designationName = record.GetType().GetProperty("DesignationName").GetValue(record).ToString();
            txtDesignationName.Text = Convert.ToString(designationName);
            string hierarchyOrderString = record.GetType().GetProperty("HierarchyOrder").GetValue(record).ToString();
            txtDesignationName.Text = Convert.ToString(designationName);
            int hierarchyOrder = Convert.ToInt16(hierarchyOrderString); 
            txtHierarchyOrder.Value = hierarchyOrder;
            desigsignationCode = Convert.ToInt32(designationCodeString);
             
            btnAdd.Text = "Update";
        }


        public bool validEntry()
        {
            if (txtHierarchyOrder.Value == 0)
            {
                MessageBox.Show("Hierarchy Order Missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDesignationName.Text.Trim() == "")
            {
                MessageBox.Show("Deignation Name Missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (  pms.chkDesignation(txtDesignationName.Text.Trim(),Convert.ToInt16(cmbDepartment.SelectedValue),Convert.ToInt16(txtHierarchyOrder.Value) )==1 )
            {
                {
                    MessageBox.Show("Duplicate Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            if (cmbDepartment.Text == "Select Department")
            {
                MessageBox.Show("Select Department");
                return false;
            }
            if ((btnAdd.Text == "Update") && (desigsignationCode == 0))
                return false;

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int departmentID = Convert.ToInt16(cmbDepartment.SelectedValue);
            int hierarchyOrder = Convert.ToInt16(txtHierarchyOrder.Value);
            string designationName = Convert.ToString(txtDesignationName.Text).Trim();
            if (validEntry() == true)
            {
                if (btnAdd.Text == "Save")
                {
                    int i = pms.addEditDesignation(departmentID,0, designationName, hierarchyOrder);
                }
                else if (btnAdd.Text == "Update")
                {
                    int j = pms.addEditDesignation(departmentID, desigsignationCode, designationName, hierarchyOrder);
                }
                UtilityFunctions.Success();
                ClearScreen();
                LoadGrid();
              

            }
        }

        

        public void LoadGrid()
        {
            ResetGrid();
            ClearScreen();
            int departmentID = Convert.ToInt16(cmbDepartment.SelectedValue);
            DataSet dsDesignation = pms.fetchDesignation(departmentID);
            List<Designation> designationListings = new List<Designation>();
            designationListings = ESCHOLPMS.UtilityFunctions.ConvertDataTable<Designation>(dsDesignation.Tables[0]);
            gridDesignation.DataSource = designationListings;
            gridDesignation.Refresh();
            gridDesignation.Visible = true;
            
        }


        

        private void btnFetch_Click_1(object sender, EventArgs e)
        {
            if (cmbDepartment.Text == "Select Department")
                return;
            cmbDepartment.Enabled = false;
            txtDesignationName.Enabled = true;
            btnFetch.Enabled = false;
            LoadGrid();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearScreen();
            cmbDepartment.Enabled = true;
            btnFetch.Enabled = true;
            gridDesignation.DataSource = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
