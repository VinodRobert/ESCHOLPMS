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
    public partial class frmUnAssignAccessCard : Form
    {
        public AccessCard ac = new AccessCard();
        Int32 spintlyUserID;
        string spintlyOrgID = Convert.ToString(GlobalVariables.spintlyOrgID);
        string spintlyAccessToken = Convert.ToString(GlobalVariables.access_token);
        string responseType = String.Empty;
        string responseMessage = String.Empty;
        int inactivateWoker = 0;
        int inactiveCard = 0;
        string accessCardNumber = string.Empty;
        public frmUnAssignAccessCard()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void ResetAll()
        {
            lblCardNumber.Visible = true;
            txtCardNumber.IntegerValue = 0;
            lblWorker.Visible = false;
            lblReUsable.Visible = false;
            lblToInactivate.Visible = false;
            btnConfirm.Visible = false;
            btnClose.Visible = true;
            rdNoReUsable.Visible = false;
            rdNoWorkerInactive.Visible = false;
            rdYesReUsable.Visible = false;
            rdYesWorkerInactive.Visible = false;
            lblWorker.Visible = false;
            lblWorkerName.Visible = false;
            lblWorkerNumber.Visible = false;
            lblWorkerID.Visible = false;
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
            DataSet dsCard = ac.GetCardDetails(cardNumber,costCentreID);
            int valid = Convert.ToInt16(dsCard.Tables[0].Rows.Count);
            if (valid==0)
            {
                MessageBox.Show("Invalid Card Number Or Card Does Not Belong To This Project", "Invalid CardNumber",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Int64 labourID = Convert.ToInt64(dsCard.Tables[0].Rows[0]["LABOURID"]);
            lblWorkerName.Text = Convert.ToString(dsCard.Tables[0].Rows[0]["WorkerName"]);
            lblWorkerNumber.Text = Convert.ToString(dsCard.Tables[0].Rows[0]["WorkerNumber"]);
            spintlyUserID = Convert.ToInt32(dsCard.Tables[0].Rows[0]["SpintlyUserID"]);
            GetImagesFromDatabase(labourID);
            ShowPhoto();
            lblReUsable.Visible = true;
            lblToInactivate.Visible = true;
            lblWorker.Visible = true;
            lblWorkerID.Visible = true;
            lblWorkerName.Visible = true;
            lblWorkerNumber.Visible = true;
            rdNoReUsable.Visible = true;
            rdNoWorkerInactive.Visible = true;
            rdYesReUsable.Visible = true;
            rdYesWorkerInactive.Visible = true;
            groupCardUsable.Visible = true;
            groupWorkerInactive.Visible = true;
            btnConfirm.Visible = true;
            rdNoReUsable.Checked = true;
            rdYesWorkerInactive.Checked = true;
        }

        private async void UnAssignCard()
        {
            string spintlyUserIDString = Convert.ToString(spintlyUserID);
            string url = "https://api.spintly.com/v2/organisationManagement/integrator/organisations/"+spintlyOrgID+"/users/"+spintlyUserIDString+"/unassignCard";
           
           

            try
            {
                RestClient client = new RestClient(url);
                RestRequest request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", spintlyAccessToken);
                UnAssignCard ucResponse = new UnAssignCard();
                IRestResponse response = await client.ExecuteAsync(request);
                
                ucResponse = JsonConvert.DeserializeObject<UnAssignCard>(response.Content);
                responseType = Convert.ToString(ucResponse.Type);
                responseMessage = Convert.ToString(ucResponse.Message);
                if (responseType == "success")
                {
                    if (inactivateWoker == 1)
                        ac.TerminateWorker(spintlyUserID);
                    if (inactiveCard == 0)
                        ac.DamageAccessCard(accessCardNumber);
                }


                MessageBox.Show("Success !!!");
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
            string cardNumber = Convert.ToString(txtCardNumber.IntegerValue);
            if (rdYesWorkerInactive.Checked == true)
                inactivateWoker = 1;
            else
                inactivateWoker = 0;
            
            if (rdYesReUsable.Checked == true)
                inactiveCard = 1;
            else
                inactiveCard = 0;

            if (spintlyAccessToken.Length == 0)
            {
                MessageBox.Show("First Authenticated. Then Run ");
                return;
            }

            UnAssignCard();


           
        }
    }
}
