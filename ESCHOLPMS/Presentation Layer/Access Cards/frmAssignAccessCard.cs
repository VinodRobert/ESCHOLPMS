using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using ESCHOLPMS.API.OauthToken;
using ESCHOLPMS.API.AccessSites;
using ESCHOLPMS.API.UnAssignCard;
using Newtonsoft.Json;
using RestSharp;
using System.IO;
using System.Data.SqlClient;
using SQLHelper;

namespace ESCHOLPMS 
{
    public partial class frmAssignAccessCard : Form
    {
        public AccessCard ac = new AccessCard();
        AssignCardHeaderRequest headerRequest = new AssignCardHeaderRequest();
        Labour worker = new Labour();
        Int64 spintlyUserID;
        string spintlyOrgID = Convert.ToString(GlobalVariables.spintlyOrgID);
        string spintlyAccessToken = Convert.ToString(GlobalVariables.access_token);
        string responseType = String.Empty;
        string responseMessage = String.Empty;
        int inactivateWoker = 0;
        int inactiveCard = 0;
        string accessCardNumber = string.Empty;
        string strJsonRequest;
        public frmAssignAccessCard()
        {
            InitializeComponent();
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
                lblPhotoFileName.Visible = true;
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
            panel1.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetAll()
        {
            lblCardNumber.Visible = true;
            txtCardNumber.IntegerValue = 0;
            lblWorker.Visible = false;
             
            btnConfirm.Visible = false;
            btnClose.Visible = true;
             
            lblWorker.Visible = false;
            lblWorkerName.Visible = false;
            
            lblWorkerID.Visible = false;
            lblWorker.Visible = false;
            txtWorkerNumber.Visible = false;
            btnFetchLabour.Visible = false;

            lblInstruction.Visible = false;
            lblTrade.Visible = false;
            lblTradeName.Visible = false;
            lblPhotoFileName.Visible = false;

            panel1.Visible = false;

        }
        private void frmUnAssignAccessCard_Load(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            if (txtCardNumber.IntegerValue == 0)
                return;
            string cardNumber = Convert.ToString(txtCardNumber.IntegerValue);
            accessCardNumber = cardNumber;
            int costCentreID = Convert.ToInt16(GlobalVariables.costCentreID);
            DataSet dsCard = ac.GetCardDetailsForAssign(cardNumber,costCentreID);
            int valid = Convert.ToInt16(dsCard.Tables[0].Rows.Count);
            if (valid==0)
            {
                MessageBox.Show("Invalid Card Number Or Card Does Not Belong To This Project or Already Assigned ", "Invalid CardNumber",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                lblWorkerID.Visible = true;
                txtWorkerNumber.Visible = true;
                btnFetchLabour.Visible = true;
            }
        }

        private async void AssignCard()
        {
            string spintlyUserIDString = Convert.ToString(spintlyUserID);
            string url = "https://api.spintly.com/v2/organisationManagement/integrator/organisations/"+spintlyOrgID+"/users/"+spintlyUserIDString+"/assignCard";
            string accessCardNumber = Convert.ToString(txtCardNumber.Text);

            headerRequest.credentialId = accessCardNumber;
            strJsonRequest = String.Empty;
            try
            {
                strJsonRequest = JsonConvert.SerializeObject(headerRequest);
            }
            catch (Exception ex)
            {
                string errorJson = "Your Data Failed To Convert To Json " + ex.Message;
                MessageBox.Show(errorJson);
            }
            try
            {
                RestClient client = new RestClient(url);
                RestRequest request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", spintlyAccessToken);
                request.AddParameter("application/json", strJsonRequest, ParameterType.RequestBody);
                UnAssignCard ucResponse = new UnAssignCard();
                IRestResponse response = await client.ExecuteAsync(request);
                
                ucResponse = JsonConvert.DeserializeObject<UnAssignCard>(response.Content);
                responseType = Convert.ToString(ucResponse.Type);
                responseMessage = Convert.ToString(ucResponse.Message);
                if (responseType == "success")
                {
                    int i = ac.AssignCardToUser(spintlyUserID, accessCardNumber);
                    MessageBox.Show("Success !!!");
                }
                else
                {
                    MessageBox.Show("Card Not Assigned To User - Contact Admin ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
                ResetAll();
                txtCardNumber.IntegerValue = 0;
                return;
            }
            catch (Exception d)
            {
                string errorJson = "Error In Calling Access Card UnAssign " + d.Message;
                MessageBox.Show(errorJson);
            }
            
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure    ?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AssignCard();
            }
            else if (dialogResult == DialogResult.No)
            {
                ResetAll();
            }


        }

        private void btnFetchLabour_Click(object sender, EventArgs e)
        {
            Int64 workerID = 0;
            btnFetchCard.Enabled = false;
            btnConfirm.Visible = false;
            if (txtWorkerNumber.Text == "")
                return;
            string who = Convert.ToString(txtWorkerNumber.Text).Trim();
            DataSet dsWho = worker.FetchSingleLabour(who);
            if (dsWho.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Un Known Worker Number", "Wrong Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                lblWorkerName.Text = Convert.ToString(dsWho.Tables[0].Rows[0]["LabourName"]);
                lblTradeName.Text = Convert.ToString(dsWho.Tables[0].Rows[0]["TypeOfLabour"]);
                spintlyUserID = Convert.ToInt64(dsWho.Tables[0].Rows[0]["SPINTLYUSERID"]);
                lblTrade.Visible = true;
                lblTradeName.Visible = true;
                lblWorker.Visible = true;
                lblWorkerName.Visible = true;
                workerID = Convert.ToInt64(dsWho.Tables[0].Rows[0]["LabourID"]);
                GetImagesFromDatabase(workerID);
                ShowPhoto();

                string currentAccessCardNumber = Convert.ToString(dsWho.Tables[0].Rows[0]["AccessCardNumber"]);
                if (currentAccessCardNumber == "-1")
                    btnConfirm.Visible = true;
                else
                {
                    MessageBox.Show("Access Card Already Attached to him !!! ", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
            }
        }
    }
}
