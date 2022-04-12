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
    public partial class frmEshcolLogins : Form
    {
        General ge = new General();
        public frmEshcolLogins()
        {
            InitializeComponent();
        }

        private void LoadLoginDetails()
        {
            gridList.ShowRowHeader = true;
            DataSet dsList = ge.FetchEshcolLogins();
            gridList.DataSource = null;
            gridList.DataSource = dsList.Tables[0];
            gridList.Refresh();
        }
        private void frmContractLabours_Load(object sender, EventArgs e)
        {

            LoadLoginDetails();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridList_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.Lavender;
                else
                    e.Style.BackColor = Color.AliceBlue;
            }
        }

        private void gridList_DrawCell(object sender, Syncfusion.WinForms.DataGrid.Events.DrawCellEventArgs e)
        {
            if (gridList.ShowRowHeader && e.RowIndex != 0)
            {
                if (e.ColumnIndex == 0)
                {
                    e.DisplayText = e.RowIndex.ToString();
                }

            }
        }

        private void btnNewLogin_Click(object sender, EventArgs e)
        {
            frmNewLogin nl = new frmNewLogin();
            nl.Show();
            LoadLoginDetails();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLoginDetails();
        }
    }
}
