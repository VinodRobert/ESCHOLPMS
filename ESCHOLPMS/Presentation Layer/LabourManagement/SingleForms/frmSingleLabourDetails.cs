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
    public partial class frmSingleLabourDetails : Form
    {
       
        Int64 labourRollNumber;
        Labour lab = new Labour();
        string currentMobileNumber = string.Empty;
        string currentIDNumber = string.Empty;
        string newLabourNumber = string.Empty;
        DataSet dsAttachments = new DataSet();


        public frmSingleLabourDetails(Int64 rollNumber)
        {
            labourRollNumber = rollNumber;
            InitializeComponent();
        }

        private void ReSetAll()
        {
            txtIDProofNumberGiven.Text = "";
            txtMobileNumber1.Text = "";
            txtMobileNumber2.Text = "";
            txtName.Text = "";
            txtParentName.Text = "";
            txtPemanentAddress.Text = "";
            txtPresentAddress.Text = "";
            txtRollNumber.Text = "";
            cmbBloodGroup.Text = "Blood Group";
            cmbGender.Text = "Sex";
            cmbIDProof.Text = "ID Proof";
            cmbJobType.Text = "Job Type";
            cmbLabourType.Text = "Labour Type";
            cmbStates.Text = "State";
            cmbSubContractor.Text = "Sub Contractor";
           
            btnCancel.Enabled = true;
             
            btnClose.Enabled = true;
            
            txtRollNumber.ReadOnly = true;
            dtDOB.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            dtDOB.Format = "dd/MM/yyyy";
            cmbAccessCards.Text = "CardNumber";
            dtDOB.DateTimeEditingMode = DateTimeEditingMode.Default;
            dtDOB.ValidationOption = ValidationResetOption.Reset;
            dtDOB.MaxDateTime = DateTime.Today;
            cmbSubContractor.Enabled = false;
            txtPIN.Text = "";
            dtDOB.Value = DateTime.Now;
            picPhoto.Image = Properties.Resources.Men;
            lblPhotoFileName.Text = "";
        }

      
      
        private void frmNewLabour_Load(object sender, EventArgs e)
        {
            LoadLabour(labourRollNumber);
            
        }

    
        private DataSet GetImagesFromDatabase(Int64 who)
        {
            DataSet DS = new DataSet();
            try
            {
                //Initialize SQL Server connection.
                string _connectionString = SqlHelper.GetConnectionString(1);

                SqlConnection CN = new SqlConnection(_connectionString);

                //Initialize SQL adapter.

                string sql = "SELECT * FROM LABOURATTACHMENTS WHERE WORKERID=" + Convert.ToString(who);
                SqlDataAdapter ADAP = new SqlDataAdapter(sql, CN);

                //Initialize Dataset.
              

                //Fill dataset with ImagesStore table.
                ADAP.Fill(DS, "Photo");

                //Fill Grid with dataset.
                dataGridView1.DataSource = DS.Tables["Photo"];
                lblPhotoFileName.Text = Convert.ToString(DS.Tables[0].Rows[0]["PHOTOFILENAME"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return DS;
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
        
                dsAttachments = GetImagesFromDatabase(who);
                DataSet dsSingleLabour = lab.FetchSingleLabour(who);
                DataRow dsWho = dsSingleLabour.Tables[0].Rows[0];
                txtRollNumber.Text = Convert.ToString(dsWho["LabourRollNo"]);
                txtName.Text = Convert.ToString(dsWho["LabourName"]);
                txtParentName.Text = Convert.ToString(dsWho["ParentName"]);
                txtPemanentAddress.Text = Convert.ToString(dsWho["PermanantAddress"]);
                txtPIN.Text = Convert.ToString(dsWho["PINCODE"]);
                txtPresentAddress.Text = Convert.ToString(dsWho["CurrentAddress"]);
                txtIDProofNumberGiven.Text = Convert.ToString(dsWho["IDProofNumber"]);
                txtMobileNumber1.Text = Convert.ToString(dsWho["MobileNumber"]);
                txtMobileNumber2.Text = Convert.ToString(dsWho["PhoneNumber"]);
                dtDOB.Value = Convert.ToDateTime(dsWho["DateofBirth"]);
                cmbAccessCards.Text = Convert.ToString(dsWho["AccessCardNumber"]);
                cmbBloodGroup.Text = Convert.ToString(dsWho["BloodGroup"]);
                cmbGender.Text = Convert.ToString(dsWho["Gender"]);
                cmbIDProof.Text = Convert.ToString(dsWho["IDProofSubmitted"]);
                cmbJobType.Text = Convert.ToString(dsWho["SkillType"]);
                cmbLabourType.Text = Convert.ToString(dsWho["TypeOfLabour"]);
                cmbStates.Text = Convert.ToString(dsWho["State"]);
                cmbSubContractor.Text = Convert.ToString(dsWho["SubContractorName"]);
                
                currentIDNumber = Convert.ToString(txtIDProofNumberGiven.Text);
                currentMobileNumber = Convert.ToString(txtMobileNumber1.Text);
         
                string currentStatus = Convert.ToString(dsWho["Status"]);
                txtProjectName.Text = Convert.ToString(dsWho["ProjectName"]);
                dtLastUpdate.Value = Convert.ToDateTime(dsWho["SiteActionDate"]);
                txtComments.Text = Convert.ToString(dsWho["TerminateComments"]);
                ShowPhoto();
                ShowAttachments();

        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenIDProof_Click(object sender, EventArgs e)
        {
            if (btnOpenIDProof.Text == "Open")
            {
                if (Convert.ToString(txtIDProofAttachment.Tag) != "")
                {
                    if (File.Exists(Convert.ToString(txtIDProofAttachment.Tag)) == true)
                    {
                        System.Diagnostics.Process.Start(Convert.ToString(txtIDProofAttachment.Tag));
                    }
                }
            }
            else
            {

                byte[] buffer = (byte[])dsAttachments.Tables[0].Rows[0]["IDPROOF"];
                //Save the PDF file
                using (FileStream fstream = new FileStream("IDProof.pdf", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    fstream.Write(buffer, 0, buffer.Length);
                }
                //This will open the PDF file so, the result will be seen in default PDF viewer
                System.Diagnostics.Process.Start("IDProof.pdf");
            }
        }

        private void btnOpenEnrollment_Click(object sender, EventArgs e)
        {
            if (btnOpenEnrollment.Text == "Open")
            {
                if (Convert.ToString(txtEnrollmentAttachment.Tag) != "")
                {
                    if (File.Exists(Convert.ToString(txtEnrollmentAttachment.Tag)) == true)
                    {
                        System.Diagnostics.Process.Start(Convert.ToString(txtEnrollmentAttachment.Tag));
                    }
                }
            }
            else
            {
                byte[] buffer = (byte[])dsAttachments.Tables[0].Rows[0]["ENROLLMENTFORM"];
                //Save the PDF file
                using (FileStream fstream = new FileStream("Enrollment.pdf", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    fstream.Write(buffer, 0, buffer.Length);
                }
                //This will open the PDF file so, the result will be seen in default PDF viewer
                System.Diagnostics.Process.Start("Enrollment.pdf");
            }

        }

        private void btnOpenTradeCertificate_Click(object sender, EventArgs e)
        {
            if (btnOpenTradeCertificate.Text == "Open")
            {
                if (Convert.ToString(txtTradeCertificate.Tag) != "")
                {
                    if (File.Exists(Convert.ToString(txtTradeCertificate.Tag)) == true)
                    {
                        System.Diagnostics.Process.Start(Convert.ToString(txtTradeCertificate.Tag));
                    }
                }
            }
            else
            {
                byte[] buffer = (byte[])dsAttachments.Tables[0].Rows[0]["TRADECERTIFICATE"];
                //Save the PDF file
                using (FileStream fstream = new FileStream("TRADECERTIFICATE.pdf", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    fstream.Write(buffer, 0, buffer.Length);
                }
                //This will open the PDF file so, the result will be seen in default PDF viewer
                System.Diagnostics.Process.Start("TRADECERTIFICATE.pdf");
            }
        }


        private void ShowAttachments()
        {
            try
            {
                txtIDProofAttachment.Text = Convert.ToString(dsAttachments.Tables[0].Rows[0]["IDPROOFFILENAME"]);
                txtEnrollmentAttachment.Text = Convert.ToString(dsAttachments.Tables[0].Rows[0]["ENROLLMENTFILENAME"]);
                txtTradeCertificate.Text = Convert.ToString(dsAttachments.Tables[0].Rows[0]["TRADECERTIFICATEFILENAME"]);

                if (txtIDProofAttachment.Text != "")
                {
                    btnOpenIDProof.Text = "View";
                    btnOpenIDProof.Visible = true;
                    btnOpenEnrollment.Text = "View";
                    btnOpenEnrollment.Visible = true;
                    btnOpenTradeCertificate.Text = "View";
                    btnOpenTradeCertificate.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

       
    }
}
