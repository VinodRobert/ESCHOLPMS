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
    public partial class frmDepartment : Form
    {
        DataSet _ds = new DataSet();
        Department _de = new Department();
        Color oddRow = Color.Transparent;
        Color evenRow = Color.AliceBlue;
     
        string _criteria;
        Int16 _departmentCode = 0;

        private void ResetGrid()
        {
            this.gridDepartment.ShowRowHeader = true;
            this.gridDepartment.ClearSelection();
            this.gridDepartment.Style.RowHeaderStyle.BackColor = Color.CadetBlue;
            this.gridDepartment.Style.RowHeaderStyle.SelectionMarkerThickness = 4;
            this.gridDepartment.Style.RowHeaderStyle.SelectionMarkerColor = Color.Red;
            this.gridDepartment.Style.RowHeaderStyle.SelectionBackColor = Color.White;
            this.gridDepartment.Style.HeaderStyle.BackColor = Color.AliceBlue;
            this.gridDepartment.Style.HeaderStyle.TextColor = Color.DarkSlateBlue;
            this.gridDepartment.Style.HeaderStyle.Font.Bold = true;
            this.gridDepartment.SelectionMode = GridSelectionMode.Single;
            this.gridDepartment.ThemeName = "Office2019Colorful";
            this.gridDepartment.TableControl.HorizontalScrollBarVisible = true;
            this.gridDepartment.TableControl.VerticalScrollBarVisible = true;
            this.gridDepartment.TableControl.HorizontalScroll.Enabled = true;
        }

        private void ClearScreen()
        {
            txtDepartmentName.Text = "";
            _departmentCode = 0;
            btnAdd.Text = "Save";
        }


        public frmDepartment()
        {
            InitializeComponent();
            gridDepartment.QueryRowStyle += gridDepartment_QueryRowStyle;
        }


        public void LoadGrid()
        {
            ResetGrid();
            ClearScreen();
           
       
            DataSet dsDepartment = _de.Fetch(null, null, "DepartmentName");
            List<Department> DepartmentListings = new List<Department>();
            DepartmentListings = ESCHOLPMS.UtilityFunctions.ConvertToList<Department>(dsDepartment.Tables[0]);
            gridDepartment.DataSource = DepartmentListings;
            gridDepartment.Refresh();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void gridDepartment_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = evenRow;
            else
                e.Style.BackColor = oddRow;
        }

        private void gridDepartment_CellButtonClick(object sender, CellButtonClickEventArgs e)
        {
       

        }

        private void gridDepartment_CellClick(object sender, CellClickEventArgs e)
        {
        
            int rowindex = e.DataRow.Index-2;
            if (rowindex < 0)
                return;
            var record = this.gridDepartment.View.Records.GetItemAt(rowindex);
            string departmentCodeString = record.GetType().GetProperty("DepartmentCode").GetValue(record).ToString();
            string departmentName = record.GetType().GetProperty("DepartmentName").GetValue(record).ToString();
            txtDepartmentName.Text = Convert.ToString(departmentName);
            _departmentCode = Convert.ToInt16(departmentCodeString);
            btnAdd.Text = "Update";
        }

        public bool validEntry()
        {
            if (txtDepartmentName.Text.Trim() == "")
            {
                MessageBox.Show("Department Name Missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            _criteria = "DepartmentName='" + Convert.ToString(txtDepartmentName.Text.Trim()) + "' AND DepartmentCode<>" + Convert.ToString(_departmentCode);

            if (Convert.ToBoolean(_de.CheckDuplicate(_criteria)) == true)
            {
                MessageBox.Show("Duplicate Entries", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((btnAdd.Text == "Update") && (_departmentCode == 0))
                return false;
            return true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validEntry() == true)
            {
                if (btnAdd.Text == "Save")
                {
                    _de.DepartmentCode = 0;
                    _de.DepartmentName = Convert.ToString(txtDepartmentName.Text).Trim();
                    _de.Update();
                }
                else if (btnAdd.Text == "Update")
                {
                    _de.DepartmentCode = _departmentCode;
                    _de.DepartmentName = Convert.ToString(txtDepartmentName.Text).Trim();
                    _de.Update();
                }
                LoadGrid();
                ClearScreen();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
