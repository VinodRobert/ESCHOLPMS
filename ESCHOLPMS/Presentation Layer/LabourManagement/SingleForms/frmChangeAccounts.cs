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
    public partial class frmChangeAccounts : Form
    {
        Int64 labourRollNumber;
        Labour lab = new Labour();
        string editMode;
        string currentMobileNumber = string.Empty;
        string currentIDNumber = string.Empty;
        string newLabourNumber = string.Empty;

        public frmChangeAccounts(Int64 rollNumber)
        {
            labourRollNumber = rollNumber;
            InitializeComponent();
        }

        private void ReSetAll()
        {
            
            txtMobileNumber1.Text = "";
            txtMobileNumber2.Text = "";
            txtName.Text = "";
            txtParentName.Text = "";
            txtPemanentAddress.Text = "";
            txtPresentAddress.Text = "";
            txtRollNumber.Text = "";
            
            cmbJobType.Text = "Job Type";
            cmbLabourType.Text = "Labour Type";
            cmbStates.Text = "State";
            cmbSubContractor.Text = "Sub Contractor";
           
            
             
            btnClose.Enabled = true;
            btnSave.Enabled = true;
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

      

        private void LoadStates()
        {
            DataSet dsStates = lab.FetchStates();
            cmbStates.DataSource = dsStates.Tables[0];
            cmbStates.Refresh();
        }

        

        private void frmNewLabour_Load(object sender, EventArgs e)
        {
            ReSetAll();
            LoadStates();
            LoadJobType();
            LoadLabourType();
            LoadAccessCards();
            LoadSubContractors();
            LoadLabour(labourRollNumber);
        }

        private void LoadJobType()
        {
            DataSet dsJobType = lab.FetchJobTypes();
            cmbJobType.DataSource = dsJobType.Tables[0];
            cmbJobType.Refresh();
        }

        private void LoadLabourType()
        {
            DataSet dsLabourType = lab.FetchLabourTypes();
            cmbLabourType.DataSource = dsLabourType.Tables[0];
            cmbLabourType.Refresh();
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
                lblPhotoFileName.Text = Convert.ToString(DS.Tables[0].Rows[0]["PHOTOFILENAME"]);
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
            
            btnSave.Visible = true;
            
            txtName.Enabled = true;
            
            txtMobileNumber1.Enabled = true;
            txtMobileNumber2.Enabled = true;
            txtParentName.Enabled = true;
            txtPemanentAddress.Enabled = true;
            txtPIN.Enabled = true;
            txtPresentAddress.Enabled = true;
            txtRollNumber.Enabled = true;
            cmbAccessCards.Enabled = true;
           
            cmbJobType.Enabled = true;
            cmbLabourType.Enabled = true;
            cmbStates.Enabled = true;
            cmbSubContractor.Enabled = true;
            lblPhotoFileName.Visible = false;
            lblStar.Visible = false;
            lblMandatory.Visible = false;
            
        }
        private void LoadLabour(Int64 who)
        {
            
                GetImagesFromDatabase(who);
                DataSet dsSingleLabour = lab.FetchSingleLabour(who);
                DataRow dsWho = dsSingleLabour.Tables[0].Rows[0];
                txtRollNumber.Text = Convert.ToString(dsWho["LabourRollNo"]);
                txtName.Text = Convert.ToString(dsWho["LabourName"]);
                txtParentName.Text = Convert.ToString(dsWho["ParentName"]);
                txtPemanentAddress.Text = Convert.ToString(dsWho["PermanantAddress"]);
                txtPIN.Text = Convert.ToString(dsWho["PINCODE"]);
                txtPresentAddress.Text = Convert.ToString(dsWho["CurrentAddress"]);
                
                txtMobileNumber1.Text = Convert.ToString(dsWho["MobileNumber"]);
                txtMobileNumber2.Text = Convert.ToString(dsWho["PhoneNumber"]);
                dtDOB.Value = Convert.ToDateTime(dsWho["DateofBirth"]);
                cmbAccessCards.Text = Convert.ToString(dsWho["AccessCardNumber"]);
                
                cmbJobType.Text = Convert.ToString(dsWho["SkillType"]);
                cmbLabourType.Text = Convert.ToString(dsWho["TypeOfLabour"]);
                cmbStates.Text = Convert.ToString(dsWho["State"]);
                cmbSubContractor.Text = Convert.ToString(dsWho["SubContractorName"]);
                editMode = "Edit";
                currentMobileNumber = Convert.ToString(txtMobileNumber1.Text);
                string currentStatus = Convert.ToString(dsWho["Status"]);
                if (cmbLabourType.Text == "CompanyLabour")
                    cmbSubContractor.Enabled = false;
                ShowPhoto();
        }

   
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int ValidateEntry()
        {
             
            string errorArea=String.Empty;
            if (cmbAccessCards.Text == "CardNumber")
                errorArea = "Access Card Number";
            if (cmbJobType.Text == "Job Type")
                errorArea = "Job Type Selection ";
            if (cmbLabourType.Text == "Labour Type")
                errorArea = "Labour Type Selection ";
            if (cmbStates.Text == "State")
                errorArea = "State Selection ";
            if (cmbSubContractor.Text == "SubContractor")
                if (cmbLabourType.Text == "Sub Contractor")
                    errorArea = "Sub Contractor Selection ";
            if (cmbAccessCards.Text == "Select Card")
                errorArea = "Access Card Selection ";
            if (txtMobileNumber1.Text == "")
                errorArea = "Mobile Number Not Entered ";
            
            if ( (lab.DuplicateMobileNumber(txtMobileNumber1.Text ) == 1) && (editMode=="New") )
                errorArea = "Mobile Number - Duplicate";
            if (txtMobileNumber1.Text != currentMobileNumber)
                if (lab.DuplicateMobileNumber(txtMobileNumber1.Text) == 1)
                    errorArea = "Mobile Number - Duplicate ";
            

           
            if (errorArea != "")
            {
                string errorMessage = "Input Error At Field - " + errorArea;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                MessageBoxAdv.Show(this, errorMessage, "Error ?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return 0;
            }

            return 1;

        }

        private void UpdateLabourDeatils()
        {
            string pmtAddress = Convert.ToString(txtPemanentAddress.Text);
            string currentAddress = Convert.ToString(txtPresentAddress.Text);
            string state = Convert.ToString(cmbStates.Text);
            string pin = Convert.ToString(txtPIN.Text);
            string mobileNumber1 = Convert.ToString(txtMobileNumber1.IntegerValue);
            string mobileNumber2 = Convert.ToString(txtMobileNumber2.IntegerValue);
            
            string typeOfLabour = Convert.ToString(cmbLabourType.Text);
            string job = Convert.ToString(cmbJobType.Text);
            int subbie = Convert.ToInt16(cmbSubContractor.SelectedValue);
            int costCentre = Convert.ToInt16(GlobalVariables.costCentreID);
            string cardNumber = Convert.ToString(cmbAccessCards.SelectedValue);
           
            int j = lab.UpdateAccounts(labourRollNumber, pmtAddress, currentAddress,state,
                pin,mobileNumber1,mobileNumber2,typeOfLabour,job,subbie,costCentre,cardNumber );

            MessageBoxAdv.Office2007Theme = Office2007Theme.Managed;

            Office2007Colors.ApplyManagedColors(this, Color.Red);

            MessageBoxAdv.Show("Sucess",  "Successfully Updated !!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            return;
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

        private void UpdateLog()
        {
            int i = lab.UpdateLog(GlobalVariables.UserID, newLabourNumber, GlobalVariables.costCentreID, 0);
        }
        

        private void cmbLabourType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLabourType.Text == "SubContractor Labour")
                cmbSubContractor.Enabled = true;
            else
                cmbSubContractor.Enabled = false;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateEntry()==1)
            {
                UpdateLabourDeatils();

            }
        }
    }
}
