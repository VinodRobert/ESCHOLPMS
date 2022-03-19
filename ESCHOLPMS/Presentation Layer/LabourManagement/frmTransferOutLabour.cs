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
    public partial class frmTransferOutLabour : Form
    {
        Int64 labourRollNumber;
        Labour lab = new Labour();
        string editMode;
        string currentMobileNumber = string.Empty;
        string currentIDNumber = string.Empty;


        public frmTransferOutLabour(Int64 rollNumber)
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
            txtRollNumber.ReadOnly = true;
            cmbAccessCards.Text = "CardNumber";
            cmbSubContractor.Enabled = false;
            picPhoto.Image = Properties.Resources.Men;
        }

        private void myEventHander(object sender,System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void LoadSubContractors()
        {
            int costCentre = GlobalVariables.costCentreID;
            DataSet dsAccessCards = lab.FetchContractors(costCentre);
            cmbSubContractor.DataSource = dsAccessCards.Tables[0];
            cmbSubContractor.Refresh();
        }


        private void LoadAccessCards()
        {
            int costCentre = GlobalVariables.costCentreID;
            DataSet dsAccessCards = lab.FetchAccessCards(costCentre);
            cmbAccessCards.DataSource = dsAccessCards.Tables[0];
            cmbAccessCards.Refresh();
        }

        
         

        private void frmNewLabour_Load(object sender, EventArgs e)
        {
            ReSetAll();
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

        private void  EnableControlsForPermanentLabour()
        {
         
            txtName.Enabled = true;
          
            txtRollNumber.Enabled = true;
            cmbAccessCards.Enabled = true;
        
            cmbJobType.Enabled = true;
            cmbLabourType.Enabled = true;
         
            cmbSubContractor.Enabled = true;
           
            
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
               
               
                LockAllInputs();
                string currentStatus = Convert.ToString(dsWho["Status"]);
                ShowPhoto();
                
               
            

        }

        private void LockAllInputs()
        {
          
            txtName.Enabled = false;
            
            txtRollNumber.Enabled = false;
            cmbAccessCards.Enabled = false;
           
            cmbJobType.Enabled = false;
            cmbLabourType.Enabled = false;
            
            cmbSubContractor.Enabled = false;
        }

        private void OpenAllInputs()
        {
           
            txtName.Enabled = true;
            
            txtRollNumber.Enabled = true;
            cmbAccessCards.Enabled = true;
            
            cmbJobType.Enabled = true;
            cmbLabourType.Enabled = true;
           
            cmbSubContractor.Enabled = true;
            if (cmbLabourType.Text == "CompanyLabour")
                cmbSubContractor.Enabled = false;
        }

        private void OpenLimitedInputs()
        {
           
            cmbJobType.Enabled = true;
            cmbLabourType.Enabled = true;
            cmbSubContractor.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ReSetAll();
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

        private void SavePhoto(Int64 existingLabourID)
        {
            try
            {
                //Read Image Bytes into a byte array
                byte[] imageData = ReadFile(lblPhotoFileName.Text);

                string _connectionString = SqlHelper.GetConnectionString(1);

                //Initialize SQL Server Connection
                SqlConnection CN = new SqlConnection(_connectionString);

                //Set insert query
                string qry = "Insert into LabourAttachments(workerID,photoFileName,photo) values(@WORKERID,@OriginalPath, @ImageData)";

                //Initialize SqlCommand object for insert.
                SqlCommand SqlCom = new SqlCommand(qry, CN);

                //We are passing Original Image Path and Image byte data as sql parameters.
             
                SqlCom.Parameters.Add(new SqlParameter("@WORKERID", (object)existingLabourID));
                SqlCom.Parameters.Add(new SqlParameter("@OriginalPath", (object)lblPhotoFileName.Text));
                SqlCom.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));

                //Open connection and execute insert query.
                CN.Open();
                SqlCom.ExecuteNonQuery();
                CN.Close();

                //Close form and return to list or images.
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdatePhoto(Int64 existingLabourID)
        {
            try
            {
                //Read Image Bytes into a byte array
                byte[] imageData = ReadFile(lblPhotoFileName.Text);

                string _connectionString = SqlHelper.GetConnectionString(1);

                //Initialize SQL Server Connection
                SqlConnection CN = new SqlConnection(_connectionString);

                //Set insert query
                string qry = "Update LabourAttachments SET PHOTO=@ImageData,PHOTOFILENAME=@ORIGINALPATH WHERE WORKERID=@WORKERID";

                //Initialize SqlCommand object for insert.
                SqlCommand SqlCom = new SqlCommand(qry, CN);

                //We are passing Original Image Path and Image byte data as sql parameters.

                SqlCom.Parameters.Add(new SqlParameter("@WORKERID", (object)existingLabourID));
                SqlCom.Parameters.Add(new SqlParameter("@OriginalPath", (object)lblPhotoFileName.Text));
                SqlCom.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));

                //Open connection and execute insert query.
                CN.Open();
                SqlCom.ExecuteNonQuery();
                CN.Close();

                //Close form and return to list or images.
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
    }
}
