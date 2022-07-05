using Syncfusion.WinForms.DataGrid;
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
    public partial class frmList_ActiveLabours : Form
    {
        Labour lab = new Labour();

        public frmList_ActiveLabours()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewLabour nl = new frmNewLabour(0, "Open");
            nl.ShowDialog();
            LoadLabours();
        }

        private void FormatGrid()
        {
            this.gridLabours.ShowRowHeader = true;
            this.gridLabours.ClearSelection();
            this.gridLabours.Style.RowHeaderStyle.BackColor = Color.CadetBlue;
            this.gridLabours.Style.RowHeaderStyle.SelectionMarkerThickness = 4;
            this.gridLabours.Style.RowHeaderStyle.SelectionMarkerColor = Color.Red;
            this.gridLabours.Style.RowHeaderStyle.SelectionBackColor = Color.White;
            this.gridLabours.Style.HeaderStyle.BackColor = Color.AliceBlue;
            this.gridLabours.Style.HeaderStyle.TextColor = Color.DarkSlateBlue;
            this.gridLabours.Style.HeaderStyle.Font.Bold = true;
            this.gridLabours.SelectionMode = GridSelectionMode.Single;
            this.gridLabours.ThemeName = "Office2019Colorful";
            this.gridLabours.TableControl.HorizontalScrollBarVisible = true;
            this.gridLabours.TableControl.VerticalScrollBarVisible = true;
            this.gridLabours.TableControl.HorizontalScroll.Enabled = true;

        }
        private void LoadLabours()
        {
            int costCentreID = Convert.ToInt16(GlobalVariables.costCentreID);
            DataSet dslabours = lab.FetchActiveUsers(costCentreID);
            List<LabourList> LabourListing = new List<LabourList>();
            LabourListing = CommonMethods.ConvertToList<LabourList>(dslabours.Tables[0]);

            gridLabours.DataSource = LabourListing;
            gridLabours.Refresh();
        }
        private void frmLabourLists_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadLabours();
        }

        private void gridLabours_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                    e.Style.BackColor = Color.Lavender;
                else
                    e.Style.BackColor = Color.AliceBlue;
            }
        }

        private void gridLabours_DrawCell(object sender, Syncfusion.WinForms.DataGrid.Events.DrawCellEventArgs e)
        {
            if (gridLabours.ShowRowHeader && e.RowIndex != 0)
            {
                if (e.ColumnIndex == 0)
                {
                    e.DisplayText = e.RowIndex.ToString();
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridLabours_DoubleClick(object sender, EventArgs e)
        {
            var rowIndex = DataGridIndexResolver.ResolveToRecordIndex(this.gridLabours.TableControl, this.gridLabours.CurrentCell.RowIndex);
            if (rowIndex != -1)
            {
                var record = (this.gridLabours.View.Records[rowIndex].Data as LabourList);
                MessageBox.Show(record.LabourID.ToString());
            }
        }

        private void gridLabours_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            var rowIndex = DataGridIndexResolver.ResolveToRecordIndex(this.gridLabours.TableControl, this.gridLabours.CurrentCell.RowIndex);
            if (rowIndex != -1)
            {
                var record = (this.gridLabours.View.Records[rowIndex].Data as LabourList);
                Int64 selectedLabour = Convert.ToInt64(record.LabourID.ToString());
                frmNewLabour nl = new frmNewLabour(selectedLabour,"Lock");
                nl.ShowDialog();
                LoadLabours();
                 
            }
        }
    }
}
