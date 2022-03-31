using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.Input.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLHelper;
using System.Data.SqlClient;
using Syncfusion.Windows.Forms;

namespace ESCHOLPMS 
{
    public partial class frmExit : Form
    {
        Int64 labourRollNumber;
        Labour lab = new Labour();
      
     

        public frmExit(Int64 rollNumber)
        {
            labourRollNumber = rollNumber;
            InitializeComponent();
        }

        private void ReSetAll()
        {
            txtName.Text = "";
            txtRollNumber.Text = "";
            cmbJobType.Text = "Job Type";
            cmbLabourType.Text = "Labour Type";
            cmbSubContractor.Text = "Sub Contractor";
            cmbAccessCards.Text = "CardNumber";
            picPhoto.Image = Properties.Resources.Men;
        }

        private void frmNewLabour_Load(object sender, EventArgs e)
        {
            ReSetAll();
            LoadLabour(labourRollNumber);
        }

      

        private void GetImagesFromDatabase(Int64 who)
        {
            try
            {
                //Initialize SQL Server connection.
                string _connectionString = SqlHelper.GetConnectionString(1);

                SqlConnection CN = new SqlConnection(_connectionString);

                //Initialize SQL adapter.

                string sql = "SELECT PHOTO,PHOTOFILENAME FROM LABOURATTACHMENTS WHERE WORKERID=" + Convert.ToString(who);
                SqlDataAdapter ADAP = new SqlDataAdapter(sql, CN);

                //Initialize Dataset.
                DataSet DS = new DataSet();

                //Fill dataset with ImagesStore table.
                ADAP.Fill(DS, "Photo");

                //Fill Grid with dataset.
                dataGridView1.DataSource = DS.Tables["Photo"];
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ShowPhoto()
        {
            byte[] imageData = (byte[])dataGridView1.Rows[0].Cells["PHOTO"].Value;

            //Initialize image variable
            Image newImage;
            //Read image data into a memory stream
            using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
            {
                ms.Write(imageData, 0, imageData.Length);

                //Set image variable value using memory stream.
                newImage = Image.FromStream(ms, true);
            }
            //
            //set picture
            picPhoto.Image = newImage;
        }


        private void LoadLabour(Int64 who)
        {

            GetImagesFromDatabase(who);
            DataSet dsSingleLabour = lab.FetchSingleLabour(who);
            DataRow dsWho = dsSingleLabour.Tables[0].Rows[0];
            txtRollNumber.Text = Convert.ToString(dsWho["LabourRollNo"]);
            txtName.Text = Convert.ToString(dsWho["LabourName"]);

            cmbAccessCards.Text = Convert.ToString(dsWho["AccessCardNumber"]);

            cmbJobType.Text = Convert.ToString(dsWho["SkillType"]);
            cmbLabourType.Text = Convert.ToString(dsWho["TypeOfLabour"]);

            cmbSubContractor.Text = Convert.ToString(dsWho["SubContractorName"]);

            string currentStatus = Convert.ToString(dsWho["Status"]);
            ShowPhoto();
        }

       

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReSetAll();
        }

    

          
        byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }

      
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < dataGridView1.Rows.Count - 1)
                {
                    //Get image data from gridview column.
                    byte[] imageData = (byte[])dataGridView1.Rows[e.RowIndex].Cells["PHOTO"].Value;

                    //Initialize image variable
                    Image newImage;
                    //Read image data into a memory stream
                    using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                    {
                        ms.Write(imageData, 0, imageData.Length);

                        //Set image variable value using memory stream.
                        newImage = Image.FromStream(ms, true);
                    }
                    //
                    //set picture
                    picPhoto.Image = newImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            if (txtTerminateRemarks.Text=="")
            {
                MessageBoxAdv.Show("Remarks Missing - Please Enter ", "Message - Error");
                return;
            }
            string message = "Do you want to Terminate This Labour ?";
            string title = "Terminate Labour";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBoxAdv.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int j = lab.ChangeActiveStatus(labourRollNumber,1,txtTerminateRemarks.Text);
                int k = lab.UpdateLog(GlobalVariables.UserID, txtRollNumber.Text, GlobalVariables.costCentreID, 9);
                MessageBoxAdv.Show("Success", "Terminated");
                this.Close();
            }
            else
            {
                return;
            }
           
        }

        private void btnTransferOut_Click(object sender, EventArgs e)
        {
            if (txtTerminateRemarks.Text == "")
            {
                MessageBoxAdv.Show("Remarks Missing - Please Enter ", "Message - Error");
                return;
            }
            string message = "Do you want to Transfer Out This Labour ?";
            string title = "Transfer Out Labour";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBoxAdv.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int j = lab.ChangeActiveStatus(labourRollNumber, 3, txtTerminateRemarks.Text);
                int k = lab.UpdateLog(GlobalVariables.UserID, txtRollNumber.Text, GlobalVariables.costCentreID, 4);
                MessageBoxAdv.Show("Success", "Terminate");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            if (txtTerminateRemarks.Text == "")
            {
                MessageBoxAdv.Show("Remarks Missing - Please Enter ", "Message - Error");
                return;
            }
            string message = "Do you want to Mark Status as Long Leave/Short Break etc  ?";
            string title = "Long Leave";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBoxAdv.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int j = lab.ChangeActiveStatus(labourRollNumber, 2, txtTerminateRemarks.Text);
                int k = lab.UpdateLog(GlobalVariables.UserID, txtRollNumber.Text, GlobalVariables.costCentreID, 6);
                MessageBoxAdv.Show("Success", "LongLeave");
                this.Close();
            }
            else
            {
                return;
            }

        }
    }
}
