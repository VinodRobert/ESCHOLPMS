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
      
    public partial class frmLinkedAccounts : Form
    {
        BillingDepartment bd = new BillingDepartment();
        public frmLinkedAccounts()
        {
            InitializeComponent();
        }
      
        private void FormatGrid()
        {
            this.gridLinked.ShowRowHeader = true;
            this.gridLinked.ClearSelection();
            this.gridLinked.Style.RowHeaderStyle.BackColor = Color.CadetBlue;
            this.gridLinked.Style.RowHeaderStyle.SelectionMarkerThickness = 4;
            this.gridLinked.Style.RowHeaderStyle.SelectionMarkerColor = Color.Red;
            this.gridLinked.Style.RowHeaderStyle.SelectionBackColor = Color.White;
            this.gridLinked.Style.HeaderStyle.BackColor = Color.AliceBlue;
            this.gridLinked.Style.HeaderStyle.TextColor = Color.DarkSlateBlue;
            this.gridLinked.Style.HeaderStyle.Font.Bold = true;
           
            this.gridLinked.ThemeName = "Office2019Colorful";
            this.gridLinked.TableControl.HorizontalScrollBarVisible = true;
            this.gridLinked.TableControl.VerticalScrollBarVisible = true;
            this.gridLinked.TableControl.HorizontalScroll.Enabled = true;

        }
        private void frmLinkedAccounts_Load(object sender, EventArgs e)
        {
            FormatGrid();
            DataSet ds = bd.FetchLinkedAccounts();
            gridLinked.DataSource = ds.Tables[0];
            gridLinked.Refresh();
        }

        private void gridLinked_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.Lavender;
                else
                    e.Style.BackColor = Color.AliceBlue;
            }
        }
    }
}
