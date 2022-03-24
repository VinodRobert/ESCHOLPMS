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

namespace ESCHOLPMS
{
    public partial class frmLabourApproval : Form
    {
        Int64 labourRollNumber;
        Int64 existingLabourID;
        Labour lab = new Labour();
        DataSet dsAttachments = new DataSet();
        string connectionString;
        SqlConnection cn;

        public frmLabourApproval(Int64 rollNumber)
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
            txtEnrollmentAttachment.Text = "";
            txtIDProofAttachment.Text = "";
            txtIDProofNumber.Text = "";
            txtIDProofSubmitted.Text = "";
            txtJobType.Text = "";
            txtLabourType.Text = "";
            txtSubContractor.Text = "";
            txtTradeCertificate.Text = "";


            btnBrowseEnrollment.Enabled = true;
            
           
            btnClose.Enabled = true;
            btnSave.Enabled = true;
            txtRollNumber.ReadOnly = true;

            picPhoto.Image = Properties.Resources.Men;
            lblPhotoFileName.Text = "";

            btnOpenEnrollment.Visible = false;
            btnOpenIDProof.Visible = false;
            btnOpenTradeCertificate.Visible = false;
           

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

        private void frmNewLabour_Load(object sender, EventArgs e)
        {
            ReSetAll();
            LoadLabour(labourRollNumber);
        }

        private void GetImagesFromDatabase(Int64 who)
        {
            try
            {
                string sql = "SELECT PHOTO,PHOTOFILENAME FROM LABOURATTACHMENTS WHERE WORKERID=" + Convert.ToString(who);
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

                string currentStatus = Convert.ToString(dsWho["STATUS"]);
              
                lblStatus.Text = "Certificate Uploaded; But not approved";
                btnBrowseEnrollment.Enabled = false;
                btnBrowseIDProof.Enabled = false;
                btnBrowseTradeCertificate.Enabled = false;
               
                btnSave.Enabled = true;
              
                lblStatus.Visible = true;
                LockAllInputs();
                ShowPhoto();
                ShowAttachments(who);
                btnSave.Text = "Approve";

            }
        }

        private void ShowAttachments(Int64 who)
        {
            try
            {
                string sql = "SELECT IDPROOF,IDPROOFFILENAME,ENROLLMENTFORM,ENROLLMENTFILENAME,TRADECERTIFICATE,TRADECERTIFICATEFILENAME   FROM LABOURATTACHMENTS WHERE WORKERID="+ Convert.ToString(who);
                SqlDataAdapter ADAP = new SqlDataAdapter(sql, cn);
                dsAttachments = new DataSet();
                ADAP.Fill(dsAttachments, "Attachments");
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

        private void LockAllInputs()
        {
            txtEnrollmentAttachment.ReadOnly = true;
            txtIDProofAttachment.ReadOnly = true;
            txtIDProofNumber.ReadOnly = true;
            txtIDProofSubmitted.ReadOnly = true;
            txtJobType.ReadOnly = true;
            txtLabourType.ReadOnly = true;
            txtName.ReadOnly = true;
            txtRollNumber.ReadOnly = true;
            txtSubContractor.ReadOnly = true;
            txtTradeCertificate.ReadOnly = true;
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


        private void UpdateLabourStatus()
        {
            int i = lab.UpdateLabourStatus("Certificate Uploaded. Not Approved", existingLabourID);
            MessageBoxAdv.Show("Certificates Uploaded Successfully !!!!!!!", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = "Are You Sure To Approve ?";
            string title = "Approval Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBoxAdv.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int i = lab.ApproveDocuments(existingLabourID);
                int j = lab.UpdateLog(GlobalVariables.UserID, txtRollNumber.Text, GlobalVariables.costCentreID, 3);
                MessageBoxAdv.Show("Approved", "Approval Done");
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

       
    }
}
