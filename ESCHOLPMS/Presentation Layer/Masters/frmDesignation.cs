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

        Int16 desigsignationCode = 0;
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
        }


        public frmDesignation()
        {
            InitializeComponent();
            gridDesignation.QueryRowStyle += gridDepartment_QueryRowStyle;
        }

        private void LoadDepartment()
        {
            DataSet dsDepartment = dept.Fetch("DepartmentCode,DepartmentName", null, "DepartmentName");
            cmbDepartment.DataSource = dsDepartment.Tables[0];
            cmbDepartment.Refresh();
        }


        private void frmDepartment_Load(object sender, EventArgs e)
        {
            ClearScreen();
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
            int rowindex = e.DataRow.Index-2;
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
            desigsignationCode = Convert.ToInt16(designationCodeString);
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

            _criteria = "DesignationName='" + Convert.ToString(txtDesignationName.Text.Trim()) + "' and DepartmentID=" + Convert.ToString(cmbDepartment.SelectedValue) + " AND DesignationCode<>" + Convert.ToString(desigsignationCode);
            if (Convert.ToBoolean(desig.CheckDuplicate(_criteria)) == true)
            {
                {
                    MessageBox.Show("Duplicate Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            if (cmbDepartment.SelectedIndex == 0)
                return false;
            if ((btnAdd.Text == "Update") && (desigsignationCode == 0))
                return false;

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validEntry() == true)
            {
                if (btnAdd.Text == "Save")
                {
                    desig.DepartmentID = Convert.ToInt16(cmbDepartment.SelectedValue);
                    desig.DesignationName = Convert.ToString(txtDesignationName.Text.Trim());
                    desig.DesignationCode = 0;
                    desig.HierarchyOrder = Convert.ToInt16(txtHierarchyOrder.Value);
                    desig.Update();
                }
                else if (btnAdd.Text == "Update")
                {
                    desig.DepartmentID = Convert.ToInt16(cmbDepartment.SelectedValue);
                    desig.DesignationName = Convert.ToString(txtDesignationName.Text.Trim());
                    desig.DesignationCode = Convert.ToInt16(desigsignationCode);
                    desig.HierarchyOrder = Convert.ToInt16(txtHierarchyOrder.Value);
                    desig.Update();
                }
                UtilityFunctions.Success();
                LoadGrid();
                ClearScreen();

            }
        }

        

        public void LoadGrid()
        {
            ResetGrid();
            ClearScreen();
            DataSet dsDesignation = desig.Fetch("DesignationCode,DesignationName,HierarchyOrder,DepartmentID", "DepartmentID=" + Convert.ToString(cmbDepartment.SelectedValue), "HierarchyOrder");
            List<Designation> designationListings = new List<Designation>();
            designationListings = ESCHOLPMS.UtilityFunctions.ConvertDataTable<Designation>(dsDesignation.Tables[0]);
            gridDesignation.DataSource = designationListings;
            gridDesignation.Refresh();
        }


        

        private void btnFetch_Click_1(object sender, EventArgs e)
        {
            cmbDepartment.Enabled = false;
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
