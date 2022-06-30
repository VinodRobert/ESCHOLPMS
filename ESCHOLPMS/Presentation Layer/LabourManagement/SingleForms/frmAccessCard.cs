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
using Syncfusion.Pdf.Parsing;


using Newtonsoft.Json;
using RestSharp;

using Newtonsoft.Json.Linq;
using ESCHOLPMS.API.OauthToken;
using ESCHOLPMS.API.AccessHistoryRequest;
using ESCHOLPMS.API.AccessHistoryResponse;


using ESCHOLPMS.Business_Layer.API;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.GridHelperClasses;



namespace ESCHOLPMS
{
    public partial class frmAccessCard : Form
    {
        string spintlyOrgID = Convert.ToString(GlobalVariables.spintlyOrgID);
        string spintlyAccessToken = Convert.ToString(GlobalVariables.access_token);
        string strJsonRequest;
        AccessHistoryRequest historyRequest = new AccessHistoryRequest();
        AccessHistoryResponse historyResponse = new AccessHistoryResponse();
        private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        int projectSpintlyAccessID = Convert.ToInt32(GlobalVariables.spintlyAccessPointID);

        PMS pms = new PMS();
        SpintlyUserForUpload oneToUpload = new SpintlyUserForUpload();
        SingleUser single = new SingleUser();


        Int64 labourRollNumber;
        Int64 existingLabourID;
        Labour lab = new Labour();
        DataSet dsAttachments = new DataSet();
        string connectionString;
        SqlConnection cn;

        public frmAccessCard(Int64 rollNumber)
        {
            labourRollNumber = rollNumber;
            existingLabourID = labourRollNumber;
            connectionString = SqlHelper.GetConnectionString(1);
            cn = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void ReSetAll()
        {
            txtName.Text = "";
            txtRollNumber.Text = "";
          
            txtIDProofNumber.Text = "";
            txtIDProofSubmitted.Text = "";
            txtJobType.Text = "";
            txtLabourType.Text = "";
            txtSubContractor.Text = "";
          
            
           
            btnClose.Enabled = true;
            btnSave.Enabled = true;
            txtRollNumber.ReadOnly = true;

            picPhoto.Image = Properties.Resources.Men;
            lblPhotoFileName.Text = "";



            cmbAccessCards.Text = "Select Card";
            lblStatus.Visible = false;

            if (File.Exists("IDProof.PDF")) 
            {
                File.Delete("IDProof.PDF");
            }
            if (File.Exists("Enrollment.pdf"))
            {
                File.Delete("Enrollment.pdf");
            }
            if (File.Exists("TRADECERTIFICATE.pdf"))
            {
                File.Delete("TRADECERTIFICATE.pdf");
            }

        }



        private void formulateUser()
        {
          
            string now = DateTime.UtcNow.ToString("dd-MM-yyyy");
            Int64 accessCardNumber = Convert.ToInt64(cmbAccessCards.SelectedValue);
            SingleUser single = new SingleUser();

            List<int> roleList = new List<int>();
            List<int> accessPointLists = new List<int>();

            roleList.Add(1750);
            accessPointLists.Add(projectSpintlyAccessID);
            single.mobile = false;
            single.email = "worker@vettoor.com";
            single.gps = false;
            single.roles = roleList;
            single.reportingTo = null;
            single.employeeCode = txtRollNumber.Text;
            single.fingerprint = false;
            single.accessPoints = accessPointLists;
            single.card = true;
            single.clickToAccessRange = "5";
            single.credentialId = accessCardNumber;
            single.deviceLock = false;
            single.joiningDate = "26-MAY-2022";
            single.probationPeriod = 30;
            single.proximityAccess = true;
            single.tapToAccess = false;
            single.accessExpiresAt = Convert.ToDateTime("31-Dec-2025");
            single.phone = txtMobileNumber.Text;
            single.gender = "male";
            single.name = txtName.Text;

            IList<SingleUser> usersToAdd = new List<SingleUser>();
            usersToAdd.Add(single);

            oneToUpload.users = usersToAdd;

            strJsonRequest = String.Empty;
            try
            {
                strJsonRequest = JsonConvert.SerializeObject(oneToUpload);
            }
            catch (Exception ex)
            {
                string errorJson = "Your Data Failed To Convert To Json " + ex.Message;
                MessageBox.Show(errorJson);
            }
        }

        private async void AddASingleUser()
        {
            string url = "https://api.spintly.com/v2/organisationManagement/integrator/organisations/674/users";

            if (spintlyAccessToken.Length == 0)
            {
                MessageBox.Show("First Authenticated. Then Run ");
                return;
            }

            try
            {
                RestClient client = new RestClient(url);
                RestRequest request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", spintlyAccessToken);
                request.AddParameter("application/json", strJsonRequest, ParameterType.RequestBody);

                IRestResponse response = await client.ExecuteAsync(request);



                ResponseSingleUserCreation createdUserList = JsonConvert.DeserializeObject<ResponseSingleUserCreation>(response.Content);
                if (createdUserList.type != "success")
                {
                    MessageBox.Show("Unable To Call API - Failed To Fetch Access Controlled Project Sites Details");
                    return;
                }

                Int64 newUserID;
                newUserID = Convert.ToInt64(createdUserList.message.userIds[0]);
                Int64 accessCardNumber = Convert.ToInt64(cmbAccessCards.SelectedValue);
                int j = pms.UpdateAccessCard(labourRollNumber, newUserID,accessCardNumber);
                this.Close();
                return;
            }
            catch (Exception d)
            {
                string errorJson = "Error In Calling Access Points List " + d.Message;
                MessageBox.Show(errorJson);
            }

        }
        private void LoadAccessCards()
        {
            int costCentre = GlobalVariables.costCentreID;
            DataSet dsAccessCards = lab.FetchAccessCards(costCentre);
            cmbAccessCards.DataSource = dsAccessCards.Tables[0];
            cmbAccessCards.Refresh();
            cmbAccessCards.Text = "Select Access Card";
        }
        private void frmNewLabour_Load(object sender, EventArgs e)
        {
            ReSetAll();
            LoadAccessCards();
            LoadLabour(labourRollNumber);
        }

        private void GetImagesFromDatabase(Int64 who)
        {
            try
            {
                string sql = "SELECT PHOTO,PHOTOFILENAME FROM LABOURATTACHMENTS WHERE ATTACHMENTID=" + Convert.ToString(who);
                SqlDataAdapter ADAP = new SqlDataAdapter(sql, cn);
                DataSet DS = new DataSet();
                ADAP.Fill(DS, "Photo");
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
            Image newImage;
            using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
            {
                ms.Write(imageData, 0, imageData.Length);
                newImage = Image.FromStream(ms, true);
            }
            picPhoto.Image = newImage;
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

                txtIDProofSubmitted.Text = Convert.ToString(dsWho["IDProofNumber"]);
                txtIDProofNumber.Text = Convert.ToString(dsWho["IDProofSubmitted"]);
                txtJobType.Text = Convert.ToString(dsWho["SkillType"]);
                txtLabourType.Text = Convert.ToString(dsWho["TypeOfLabour"]);
                txtSubContractor.Text = Convert.ToString(dsWho["SubContractorName"]);
                txtMobileNumber.Text = Convert.ToString(dsWho["MobileNumber"]);
                string currentStatus = Convert.ToString(dsWho["STATUS"]);
              
                lblStatus.Text = "Access Card To Assign";
              
               
                btnSave.Enabled = true;
                dtActionDate.Value = Convert.ToDateTime(dsWho["SITEACTIONDATE"]);
                lblStatus.Visible = true;
                LockAllInputs();
                ShowPhoto();
             
                btnSave.Text = "Upload";

            }
        }



        private void LockAllInputs()
        {
          
            txtIDProofNumber.ReadOnly = true;
            txtIDProofSubmitted.ReadOnly = true;
            txtJobType.ReadOnly = true;
            txtLabourType.ReadOnly = true;
            txtName.ReadOnly = true;
            txtRollNumber.ReadOnly = true;
            txtSubContractor.ReadOnly = true;
          
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
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        private void SavePhoto(Int64 existingLabourID)
        {
            try
            {
                byte[] imageData = ReadFile(lblPhotoFileName.Text);
                string qry = "Insert into LabourAttachments(workerID,photoFileName,photo) values(@WORKERID,@OriginalPath, @ImageData)";
                SqlCommand SqlCom = new SqlCommand(qry, cn);
                SqlCom.Parameters.Add(new SqlParameter("@WORKERID", (object)existingLabourID));
                SqlCom.Parameters.Add(new SqlParameter("@OriginalPath", (object)lblPhotoFileName.Text));
                SqlCom.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));
                cn.Open();
                SqlCom.ExecuteNonQuery();
                cn.Close();
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
                byte[] imageData = ReadFile(lblPhotoFileName.Text);
                string qry = "Update LabourAttachments SET PHOTO=@ImageData,PHOTOFILENAME=@ORIGINALPATH WHERE WORKERID=@WORKERID";
                SqlCommand SqlCom = new SqlCommand(qry, cn);
                SqlCom.Parameters.Add(new SqlParameter("@WORKERID", (object)existingLabourID));
                SqlCom.Parameters.Add(new SqlParameter("@OriginalPath", (object)lblPhotoFileName.Text));
                SqlCom.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));
                cn.Open();
                SqlCom.ExecuteNonQuery();
                cn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


     

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbAccessCards.Text =="Select Access Card")
            {
                MessageBox.Show("Access Card Not Selectd");
                return;
            }
            string message = "Are You Sure To Assign Card and Upload ??";
            string title = "Upload Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBoxAdv.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                formulateUser();
                AddASingleUser();
                MessageBoxAdv.Show("Uploaded", "Upload  Done");
                this.Close();
            }
            else
            {
                this.Close();
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
