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
    public partial class frmNewLabour : Form
    {
        Int64 labourRollNumber;
        Labour lab = new Labour();
        string editMode;
        string currentMobileNumber = string.Empty;
        string currentIDNumber = string.Empty;
        string newLabourNumber = string.Empty;

        public frmNewLabour(Int64 rollNumber)
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
            btnBrowse.Enabled = true;
            btnCancel.Enabled = true;
            btnClear.Enabled = true;
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

        private void LoadIDProof()
        {
            DataSet dsIDProof = lab.FetchIDProofS();
            cmbIDProof.DataSource = dsIDProof.Tables[0];
            cmbIDProof.Refresh();
        }

        private void LoadStates()
        {
            DataSet dsStates = lab.FetchStates();
            cmbStates.DataSource = dsStates.Tables[0];
            cmbStates.Refresh();
        }

        private void LoadSex()
        {
            DataSet dsSex = lab.FetchSex();
            cmbGender.DataSource = dsSex.Tables[0];
            cmbGender.Refresh();
        }

        private void frmNewLabour_Load(object sender, EventArgs e)
        {
            ReSetAll();
           

            LoadStates();
            LoadSex();
            LoadBloodGroup();
            LoadJobType();
            LoadLabourType();
            LoadIDProof();
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
        private void LoadBloodGroup()
        {
            DataSet dsBloodGroup = lab.FetchBloodGroup();
            cmbBloodGroup.DataSource = dsBloodGroup.Tables[0];
            cmbBloodGroup.Refresh();
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
            btnBrowse.Visible = false;
            btnClear.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            txtName.Enabled = true;
            txtIDProofNumberGiven.Enabled = true;
            txtMobileNumber1.Enabled = true;
            txtMobileNumber2.Enabled = true;
            txtParentName.Enabled = true;
            txtPemanentAddress.Enabled = true;
            txtPIN.Enabled = true;
            txtPresentAddress.Enabled = true;
            txtRollNumber.Enabled = true;
            cmbAccessCards.Enabled = true;
            cmbBloodGroup.Enabled = true;
            cmbGender.Enabled = true;
            cmbIDProof.Enabled = true;
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
            if (who != 0)
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
                editMode = "Edit";
                currentIDNumber = Convert.ToString(txtIDProofNumberGiven.Text);
                currentMobileNumber = Convert.ToString(txtMobileNumber1.Text);
                LockAllInputs();
                string currentStatus = Convert.ToString(dsWho["Status"]);
                ShowPhoto();
                btnSave.Text = "Update";
                if (currentStatus == "New")
                    OpenAllInputs();
                else if (currentStatus == "Permanent Labour")
                    EnableControlsForPermanentLabour();
                else
                    OpenLimitedInputs();
            }
            else
            {
                editMode = "New";
            }

        }

        private void LockAllInputs()
        {
            txtIDProofNumberGiven.Enabled = false;
            txtMobileNumber1.Enabled = false;
            txtMobileNumber2.Enabled = false;
            txtName.Enabled = false;
            txtParentName.Enabled = false;
            txtPemanentAddress.Enabled = false;
            txtPIN.Enabled = false;
            txtPresentAddress.Enabled = false;
            txtRollNumber.Enabled = false;
            cmbAccessCards.Enabled = false;
            cmbBloodGroup.Enabled = false;
            cmbGender.Enabled = false;
            cmbIDProof.Enabled = false;
            cmbJobType.Enabled = false;
            cmbLabourType.Enabled = false;
            cmbStates.Enabled = false;
            cmbSubContractor.Enabled = false;
        }

        private void OpenAllInputs()
        {
            txtIDProofNumberGiven.Enabled = true;
            txtMobileNumber1.Enabled = true;
            txtMobileNumber2.Enabled = true;
            txtName.Enabled = true;
            txtParentName.Enabled = true;
            txtPemanentAddress.Enabled = true;
            txtPIN.Enabled = true;
            txtPresentAddress.Enabled = true;
            txtRollNumber.Enabled = true;
            cmbAccessCards.Enabled = true;
            cmbBloodGroup.Enabled = true;
            cmbGender.Enabled = true;
            cmbIDProof.Enabled = true;
            cmbJobType.Enabled = true;
            cmbLabourType.Enabled = true;
            cmbStates.Enabled = true;
            cmbSubContractor.Enabled = true;
            if (cmbLabourType.Text == "CompanyLabour")
                cmbSubContractor.Enabled = false;
        }

        private void OpenLimitedInputs()
        {
            txtMobileNumber2.Enabled = true;
            txtPresentAddress.Enabled = true;
            cmbLabourType.Enabled = true;
            cmbLabourType.Style.EditorStyle.BackColor = Color.Aqua;
            cmbLabourType.Style.EditorStyle.BorderColor = Color.Red;
            cmbLabourType.Style.EditorStyle.ForeColor = Color.Blue;
            cmbLabourType.Style.EditorStyle.Font = new Font("Arial", 10F, FontStyle.Bold);

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

        private int ValidateEntry()
        {
             
            string errorArea=String.Empty;
            if (cmbAccessCards.Text == "CardNumber")
                errorArea = "Access Card Number";
            if (txtName.Text == "")
                errorArea = "Name";
            if (cmbBloodGroup.Text == "Blood Group")
                errorArea = "Blood Group Selection ";
            if (cmbGender.Text == "Sex")
                errorArea = "Gender Selection ";
            if (cmbIDProof.Text == "ID Proof")
                errorArea = "ID Proof Selection ";
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
            if (txtIDProofNumberGiven.Text == "")
                errorArea = "ID Proof Number Not Given ";
            if ( (lab.DuplicateMobileNumber(txtMobileNumber1.Text ) == 1) && (editMode=="New") )
                errorArea = "Mobile Number - Duplicate";
            if  ( (lab.DuplicateIDProofNumber(txtIDProofNumberGiven.Text ) == 1) && (editMode=="New") )
                errorArea = "ID Proof Number - Duplicate";
            if (txtMobileNumber1.Text != currentMobileNumber)
                if (lab.DuplicateMobileNumber(txtMobileNumber1.Text) == 1)
                    errorArea = "Mobile Number - Duplicate ";
            if (txtIDProofNumberGiven.Text != currentIDNumber)
                if (lab.DuplicateIDProofNumber(txtIDProofNumberGiven.Text) == 1)
                    errorArea = "Duplicate ID Proof Number";

            if (lblPhotoFileName.Text == "")
                errorArea = "Photo Missing ";
            if (errorArea != "")
            {
                string errorMessage = "Input Error At Field - " + errorArea;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                MessageBoxAdv.Show(this, errorMessage, "Error ?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return 0;
            }

            return 1;

        }

        private void SaveNewLabour()
        {
            string name = Convert.ToString(txtName.Text);
            string gender = Convert.ToString(cmbGender.Text);
            DateTime dob = Convert.ToDateTime(dtDOB.Value);
            string parentName = Convert.ToString(txtParentName.Text);
            string bloodGroup = Convert.ToString(cmbBloodGroup.Text);
            string pmtAddress = Convert.ToString(txtPemanentAddress.Text);
            string currentAddress = Convert.ToString(txtPresentAddress.Text);
            string state = Convert.ToString(cmbStates.Text);
            string pin = Convert.ToString(txtPIN.Text);
            string mobileNumber1 = Convert.ToString(txtMobileNumber1.IntegerValue);
            string mobileNumber2 = Convert.ToString(txtMobileNumber2.IntegerValue);
            string idProof = Convert.ToString(cmbIDProof.Text);
            string idProofNumber = Convert.ToString(txtIDProofNumberGiven.Text);
            string typeOfLabour = Convert.ToString(cmbLabourType.Text);
            string job = Convert.ToString(cmbJobType.Text);
            int subbie = Convert.ToInt16(cmbSubContractor.SelectedValue);
            int costCentre = Convert.ToInt16(GlobalVariables.costCentreID);
            string cardNumber = Convert.ToString(cmbAccessCards.SelectedValue);
            DataSet dsNewLabour = lab.CreateNewLabour(name,gender,dob,parentName,bloodGroup,pmtAddress,currentAddress,state,
                pin,mobileNumber1,mobileNumber2,idProof,idProofNumber,typeOfLabour,job,subbie,costCentre,cardNumber );


            newLabourNumber = Convert.ToString(dsNewLabour.Tables[0].Rows[0]["LabourRollNo"]);
            
            Int64 newLabourID = Convert.ToInt64(dsNewLabour.Tables[0].Rows[0]["LABOURRUNNINGNUMBER"]);
            SavePhoto(newLabourID);

        
            txtRollNumber.Text = newLabourNumber.ToString();

            MessageBoxAdv.Office2007Theme = Office2007Theme.Managed;

            Office2007Colors.ApplyManagedColors(this, Color.Red);

            MessageBoxAdv.Show(this,  "New Labour Created with Tempoary Number  "+newLabourNumber.ToString(), "New Labour Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                 
            LoadAccessCards();
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
                string path = Convert.ToString(lblPhotoFileName.Text).Trim();
                if (File.Exists(path))
                {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void UpdateLabour()
        {
            string name = Convert.ToString(txtName.Text);
            string gender = Convert.ToString(cmbGender.Text);
            DateTime dob = Convert.ToDateTime(dtDOB.Value);
            string parentName = Convert.ToString(txtParentName.Text);
            string bloodGroup = Convert.ToString(cmbBloodGroup.Text);
            string pmtAddress = Convert.ToString(txtPemanentAddress.Text);
            string currentAddress = Convert.ToString(txtPresentAddress.Text);
            string state = Convert.ToString(cmbStates.Text);
            string pin = Convert.ToString(txtPIN.Text);
            string mobileNumber1 = Convert.ToString(txtMobileNumber1.Text);
            string mobileNumber2 = Convert.ToString(txtMobileNumber2.Text);
            string idProof = Convert.ToString(cmbIDProof.Text);
            string idProofNumber = Convert.ToString(txtIDProofNumberGiven.Text);
            string typeOfLabour = Convert.ToString(cmbLabourType.Text);
            string job = Convert.ToString(cmbJobType.Text);
            int subbie = Convert.ToInt16(cmbSubContractor.SelectedValue);
            int costCentre = Convert.ToInt16(GlobalVariables.costCentreID);
            string cardNumber = Convert.ToString(cmbAccessCards.SelectedValue);
            Int64 existingLabourID = Convert.ToInt64(labourRollNumber);
            int result = lab.UpdateLabour(existingLabourID, name, gender, dob, parentName, bloodGroup, pmtAddress, currentAddress, state,
                pin, mobileNumber1, mobileNumber2, idProof, idProofNumber, typeOfLabour, job, subbie, costCentre, cardNumber);

            UpdatePhoto(existingLabourID);

            MessageBoxAdv.Office2007Theme = Office2007Theme.Black;

            MessageBoxAdv.Show(this, "Details Updated !!!", "Updation ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


          
            LoadAccessCards();
            this.Close();
            return;
        }
         
        private void UpdateLog()
        {
            int i = lab.UpdateLog(GlobalVariables.UserID, newLabourNumber, GlobalVariables.costCentreID, 0);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                if (ValidateEntry() == 1)
                {
                    SaveNewLabour();
                    UpdateLog();
                }
            }
            if (btnSave.Text == "Update")
            {
                if (ValidateEntry() == 1)
                    UpdateLabour();
            }

        }

        private void cmbLabourType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLabourType.Text == "SubContractor Labour")
                cmbSubContractor.Enabled = true;
            else
                cmbSubContractor.Enabled = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFilePhoto.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (openFilePhoto.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image = Image.FromFile(openFilePhoto.FileName);
                lblPhotoFileName.Text = Convert.ToString(openFilePhoto.FileName);
                lblPhotoFileName.Visible = false;
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
