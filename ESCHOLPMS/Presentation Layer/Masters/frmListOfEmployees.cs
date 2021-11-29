using Syncfusion.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESCHOLPMS
{ 
    public partial class frmListOfEmployees : Form
    {
        DataSet dsEmployeeList = new DataSet();
        EmployeeMaster emp = new EmployeeMaster();
        Color oddRow = Color.Transparent;
        Color evenRow = Color.AliceBlue;
        PMS pms = new PMS();

        public frmListOfEmployees()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetGrid()
        {
            this.gridEmployeeLists.ShowRowHeader = true;
            this.gridEmployeeLists.ClearSelection();
            this.gridEmployeeLists.Style.RowHeaderStyle.BackColor = Color.CadetBlue;
            this.gridEmployeeLists.Style.RowHeaderStyle.SelectionMarkerThickness = 4;
            this.gridEmployeeLists.Style.RowHeaderStyle.SelectionMarkerColor = Color.Red;
            this.gridEmployeeLists.Style.RowHeaderStyle.SelectionBackColor = Color.White;
            this.gridEmployeeLists.Style.HeaderStyle.BackColor = Color.AliceBlue;
            this.gridEmployeeLists.Style.HeaderStyle.TextColor = Color.DarkSlateBlue;
            this.gridEmployeeLists.Style.HeaderStyle.Font.Bold = true;
            this.gridEmployeeLists.SelectionMode = GridSelectionMode.Single;
            this.gridEmployeeLists.ThemeName = "Office2019Colorful";
            this.gridEmployeeLists.TableControl.HorizontalScrollBarVisible = true;
            this.gridEmployeeLists.TableControl.VerticalScrollBarVisible = true;
            this.gridEmployeeLists.TableControl.HorizontalScroll.Enabled = true;
      
            this.gridEmployeeLists.Columns[4].ImmediateUpdateColumnFilter = true;
            this.gridEmployeeLists.Columns[5].ImmediateUpdateColumnFilter = true;
           
           
             
        }


        private void LoadGrid()
        {
            dsEmployeeList = pms.FetchActiveEmployeeDetails();
            List<EmployeeListing> EmployeeListings = new List<EmployeeListing>();
            EmployeeListings = ESCHOLPMS.UtilityFunctions.ConvertToList<EmployeeListing>(dsEmployeeList.Tables[0]);

            gridEmployeeLists.DataSource = EmployeeListings;
            //gridPager.PageSize = 16;
            //gridEmployeeLists.DataSource = gridPager.PagedSource;

            gridEmployeeLists.Refresh();
        }
        private void frmListOfEmployees_Load(object sender, EventArgs e)
        {
            ResetGrid();
            LoadGrid();
            panelNewEmployee.Visible = false;
        }

        private void gridEmployeeLists_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {

            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = evenRow;
            else
                e.Style.BackColor = oddRow;
        }

        private void gridEmployeeLists_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            int rowindex = e.DataRow.Index - 2;
            if (rowindex < 0)
                return;
            var record = this.gridEmployeeLists.View.Records.GetItemAt(rowindex);
            string employeeCodeString = record.GetType().GetProperty("EmployeeCode").GetValue(record).ToString();
            int employeeCode = Convert.ToInt16(employeeCodeString);
            label1.Text = employeeCodeString;
            frmEmployee frmEmp = new frmEmployee(employeeCode);
            frmEmp.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            gridEmployeeLists.Enabled = false;
            panelNewEmployee.Visible = true;
            txtEmployeeCode.Text = "0";
            txtEmployeeName.Text = "";
        }

        private void btnSaveNewEmployee_Click(object sender, EventArgs e)
        {
            if (txtEmployeeCode.Text == "")
                return;
            if (txtEmployeeCode.Text == "0")
                return;
            if (txtEmployeeName.Text == "")
                return;
            int success = emp.AddNewEmployee(txtEmployeeCode.Text, txtEmployeeName.Text);
            if (success==0)
            {
                MessageBox.Show("Un Sucessful - May be Duplicate Entry ");
                return;
            }
            string newEmployeeNumber = Convert.ToString(txtEmployeeCode.Text).Trim();
            panelNewEmployee.Visible = false;
            LoadGrid();
            gridEmployeeLists.Enabled = true;
            gridEmployeeLists.Columns["EmployeeNumber"].FilterPredicates.Add(new FilterPredicate() { FilterType = FilterType.Equals, FilterValue = newEmployeeNumber });
        }

        private void gridEmployeeLists_DrawCell(object sender, Syncfusion.WinForms.DataGrid.Events.DrawCellEventArgs e)
        {
            if (gridEmployeeLists.ShowRowHeader && e.RowIndex != 0)
            {
                if (e.ColumnIndex == 0)
                {
                    e.DisplayText = e.RowIndex.ToString();
                }

            }
        }
    }
}
