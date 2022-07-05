using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGridConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.GridHelperClasses;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Grid;
using System.IO;

namespace ESCHOLPMS
{
    public partial class frmListSubContractor_Workers : Form
    {
        Labour lab = new Labour();
        int indexCode;
        public frmListSubContractor_Workers()
        {
            InitializeComponent();
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
        private void LoadLabours(int indexCode)
        {
            int costCentreID = Convert.ToInt16(GlobalVariables.costCentreID);
            DataSet dslabours =  lab.FetchCompleteLaboursList(costCentreID,3);
      
            List<LabourList> LabourListing = new List<LabourList>();
            LabourListing = CommonMethods.ConvertToList<LabourList>(dslabours.Tables[0]);

            gridLabours.DataSource = LabourListing;
            gridLabours.Refresh();
        }

        private void frmLabourLists_Load(object sender, EventArgs e)
        {
            FormatGrid();
            LoadLabours(1);
        }

       

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void options_HeaderFooterExporting(object sender, Syncfusion.WinForms.DataGridConverter.Events.PdfHeaderFooterEventArgs e)
        {
            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 15f, PdfFontStyle.Bold);
            var width = e.PdfPage.GetClientSize().Width;
            PdfPageTemplateElement header = new PdfPageTemplateElement(width, 38);
            PdfPageTemplateElement footer = new PdfPageTemplateElement(width, 38);

            string projectName = GlobalVariables.ProjectName;
            var dateTime = DateTime.Now;
            string heading = projectName + " Sub Contractor - Labour List ";
            string reportDate = "Report Date : "+ dateTime.ToShortDateString();  
            header.Graphics.DrawString(heading, font, PdfPens.Black, 15, 1);
            footer.Graphics.DrawString(reportDate, font, PdfPens.Black, 10, 1);    
            e.PdfDocumentTemplate.Top = header;
            e.PdfDocumentTemplate.Bottom = footer;
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            PdfExportingOptions options = new PdfExportingOptions();
            options.AutoColumnWidth = false;
            options.AutoRowHeight = true;
            options.RepeatHeaders = true;
            options.FitAllColumnsInOnePage = true;
            options.ExcludeColumns.Add("Status");
            options.ExcludeColumns.Add("SpintlyID");
            options.ExcludeColumns.Add("LastCheckInDate");
            options.ExcludeColumns.Add("LabourID");
            options.ExcludeColumns.Add("DateOfJoining");
            options.ExcludeColumns.Add("DUE");
            options.ExcludeColumns.Add("MobileNumber");
            options.ExcludeColumns.Add("AccessCardNumber");
            options.ExcludeColumns.Add("CheckInCount");
            options.ExcludeColumns.Add("ProjectName");
            options.ExcludeColumns.Add("Due");
            options.ExcludeColumns.Add("LastCheckIn");

            options.HeaderFooterExporting += options_HeaderFooterExporting;
            var document = new PdfDocument();
            document.PageSettings.Orientation = PdfPageOrientation.Landscape;
            document = gridLabours.ExportToPdf(options);
          
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files(*.pdf)|*.pdf"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = saveFileDialog.OpenFile())
                {
                    document.Save(stream);
                }
                //Message box confirmation to view the created Pdf file.
                if (MessageBox.Show("Do you want to view the Pdf file?", "Pdf file has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Launching the Pdf file using the default Application.
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
        }
    }
     
}
