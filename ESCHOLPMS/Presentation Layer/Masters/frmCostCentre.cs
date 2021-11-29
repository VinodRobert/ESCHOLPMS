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
    public partial class frmCostCentre : Form
    {
      
        PMS pms = new PMS();

       
    
        Color oddRow = Color.Transparent;
        Color evenRow = Color.AliceBlue;

        private void ResetGrid()
        {
            this.grid.ShowRowHeader = true;
            this.grid.ClearSelection();
            this.grid.Style.RowHeaderStyle.BackColor = Color.CadetBlue;
            this.grid.Style.RowHeaderStyle.SelectionMarkerThickness = 4;
            this.grid.Style.RowHeaderStyle.SelectionMarkerColor = Color.Red;
            this.grid.Style.RowHeaderStyle.SelectionBackColor = Color.White;
            this.grid.Style.HeaderStyle.BackColor = Color.AliceBlue;
            this.grid.Style.HeaderStyle.TextColor = Color.DarkSlateBlue;
            this.grid.Style.HeaderStyle.Font.Bold = true;
            this.grid.SelectionMode = GridSelectionMode.Single;
            this.grid.ThemeName = "Office2019Colorful";
            this.grid.TableControl.HorizontalScrollBarVisible = true;
            this.grid.TableControl.VerticalScrollBarVisible = true;
            this.grid.TableControl.HorizontalScroll.Enabled = true;
        }

     

        public frmCostCentre()
        {
            InitializeComponent();
            grid.QueryRowStyle += gridDepartment_QueryRowStyle;
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


  

        

        public void LoadGrid()
        {
            ResetGrid();
            DataSet dsCosCentre = pms.fetchCostCentre();
            grid.DataSource = dsCosCentre.Tables[0];
            grid.Refresh();
            grid.Visible = true;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
