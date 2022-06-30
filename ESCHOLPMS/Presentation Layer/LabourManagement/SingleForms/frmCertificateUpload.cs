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
    public partial class frmCertificateUpload : Form
    {
        Int64 labourRollNumber;
        Int64 existingLabourID;
        Labour lab = new Labour();
        DataSet dsAttachments = new DataSet();
        string connectionString;
        SqlConnection cn;
        DataSet dsRejection;
      


        public frmCertificateUpload(Int64 rollNumber)
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
            btnReUpload.Visible = false;

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


        private void LoadRejection(Int64 labourID)
        {
            dsRejection = lab.FetchRejections(labourID);
            gridRejection.DataSource = dsRejection.Tables[0];
            gridRejection.Refresh();
        }
        private void frmNewLabour_Load(object sender, EventArgs e)
        {
            ReSetAll();
            LoadRejection(labourRollNumber);
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
                if (currentStatus == "New")
                {
                    lblStatus.Text = "Certificates Not Uploaded";
                    btnOpenEnrollment.Visible = false;
                    btnOpenIDProof.Visible = false;
                    btnOpenTradeCertificate.Visible = false;
                }
                else if (currentStatus == "Certificate Uploaded. Not Approved")
                {
                    lblStatus.Text = "Certificate Uploaded; But not approved";
                    btnBrowseEnrollment.Enabled = false;
                    btnBrowseIDProof.Enabled = false;
                    btnBrowseTradeCertificate.Enabled = false;
                    btnReUpload.Visible = true;
                    btnSave.Enabled = false;
                }
                else if (currentStatus == "Rejected")
                {
                    lblStatus.Text = "HR Rejected Submission";
                    btnBrowseEnrollment.Enabled = false;
                    btnBrowseIDProof.Enabled = false;
                    btnBrowseTradeCertificate.Enabled = false;
                    btnReUpload.Visible = true;
                    btnSave.Enabled = false;
                    btnReSubmission.Visible = true;
                    panelRejection.Visible = true;
                }
                dtActionDate.Value = Convert.ToDateTime(dsWho["SiteActionDate"]);
                lblStatus.Visible = true;
                LockAllInputs();
                ShowPhoto();
                ShowAttachments(who);
                btnSave.Text = "Update";

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
            string errorArea = String.Empty;
            string filetype;
            string filename;

            if (txtIDProofAttachment.Text == "")
                errorArea = "ID Proof Attachment Missing ";
            if (txtEnrollmentAttachment.Text == "")
                errorArea = "Enrollment  Attachment Missing ";
            if (txtTradeCertificate.Text == "")
                errorArea = "Trader Certificate Missing ";

            if (errorArea != "")
            {
                string errorMessage = "Missing Details - " + errorArea;
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Default;
                MessageBoxAdv.Show(this, errorMessage, "Error ?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return 0;
            }


            filename = txtIDProofAttachment.Text.Substring(Convert.ToInt32(txtIDProofAttachment.Text.LastIndexOf("\\")) + 1, txtIDProofAttachment.Text.Length - (Convert.ToInt32(txtIDProofAttachment.Text.LastIndexOf("\\")) + 1));
            filetype = txtIDProofAttachment.Text.Substring(Convert.ToInt32(txtIDProofAttachment.Text.LastIndexOf(".")) + 1, txtIDProofAttachment.Text.Length - (Convert.ToInt32(txtIDProofAttachment.Text.LastIndexOf(".")) + 1));

            if (filetype.ToUpper() != "PDF")
            {
                MessageBox.Show("Upload Only PDF Files");
                return 0;
            }

            try
            {
                long allbytes = new FileInfo(txtIDProofAttachment.Text).Length;
                if (allbytes > 1024000)
                {
                    MessageBox.Show("ID Proof Attachment Size Must Be Less Than 1 MB.");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during File Read " + ex.ToString());
            }

            filename = txtEnrollmentAttachment.Text.Substring(Convert.ToInt32(txtEnrollmentAttachment.Text.LastIndexOf("\\")) + 1, txtEnrollmentAttachment.Text.Length - (Convert.ToInt32(txtEnrollmentAttachment.Text.LastIndexOf("\\")) + 1));
            filetype = txtEnrollmentAttachment.Text.Substring(Convert.ToInt32(txtEnrollmentAttachment.Text.LastIndexOf(".")) + 1, txtEnrollmentAttachment.Text.Length - (Convert.ToInt32(txtEnrollmentAttachment.Text.LastIndexOf(".")) + 1));
            if (filetype.ToUpper() != "PDF")
            {
                MessageBox.Show("Upload Only PDF Files");
                return 0;
            }
            try
            {
                long allbytesEnroll = new FileInfo(txtEnrollmentAttachment.Text).Length;
                if (allbytesEnroll > 1024000)
                {
                    MessageBox.Show("Enrollment  Attachment Size Must NOT Exceed 1 MB.");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during File Read " + ex.ToString());
            }

            filename = txtTradeCertificate.Text.Substring(Convert.ToInt32(txtTradeCertificate.Text.LastIndexOf("\\")) + 1, txtTradeCertificate.Text.Length - (Convert.ToInt32(txtTradeCertificate.Text.LastIndexOf("\\")) + 1));
            filetype = txtTradeCertificate.Text.Substring(Convert.ToInt32(txtTradeCertificate.Text.LastIndexOf(".")) + 1, txtTradeCertificate.Text.Length - (Convert.ToInt32(txtTradeCertificate.Text.LastIndexOf(".")) + 1));
            if (filetype.ToUpper() != "PDF")
            {
                MessageBox.Show("Upload Only PDF Files");
                return 0;
            }

            try
            {
                long allbytesTrade = new FileInfo(txtTradeCertificate.Text).Length;
                if (allbytesTrade > 1024000)
                {
                    MessageBox.Show("Trade Certificate  Form Size Must Be Less Than 1 MB.");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during File Read " + ex.ToString());
            }
            return 1;
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
            MessageBoxAdv.Show("Please Wait.Time Consuming...Press OK and Relax !!!");
            btnSave.Enabled = false;
            if (btnSave.Text == "Update")
            {
                if (ValidateEntry() == 1)
                {
                    int success = SaveAttachments();
                    if (success == 1)
                    {
                        UpdateLabourStatus();
                        int j = lab.UpdateLog(GlobalVariables.UserID, txtRollNumber.Text, GlobalVariables.costCentreID, 1);
                        this.Close();
                    }
                }
                
            }
        }



        private int SaveAttachments()
        {
            MemoryStream streamIDProof = new MemoryStream();
            MemoryStream streamEnrollment = new MemoryStream();
            MemoryStream streamTrade = new MemoryStream();
            PdfLoadedDocument idProof;
            PdfLoadedDocument idEnrollment;
            PdfLoadedDocument idTrade;
            try
            {
                idProof = new PdfLoadedDocument(txtIDProofAttachment.Text);
                idEnrollment = new PdfLoadedDocument(txtEnrollmentAttachment.Text);
                idTrade = new PdfLoadedDocument(txtTradeCertificate.Text);
            }
            catch
            {
                MessageBoxAdv.Show("Please Check The FILE NAME . It must be Very Simple !!!", "Error");
                btnReUpload.Enabled = true;
                btnReUpload.Visible = true;
                btnSave.Enabled = true;
                return 0;
            }

            
            idProof.Save(streamIDProof);
            idEnrollment.Save(streamEnrollment);
            idTrade.Save(streamTrade);

            string qry = "Update LabourAttachments SET ";
            qry = qry + "IDPROOF        = @ImageIDProof   , IDPROOFFILENAME    =@IDProofFileName, ";
            qry = qry + "ENROLLMENTFORM = @ImageEnrollment, ENROLLMENTFILENAME =@EnrollmentFileName,";
            qry = qry + "TRADECERTIFICATE=@ImageTrade,      TRADECERTIFICATEFILENAME=@TradeCertificateFileName";
            qry = qry + "     WHERE WORKERID=@WORKERID";
            SqlCommand SqlCom = new SqlCommand(qry, cn);
            SqlCom.Parameters.Add(new SqlParameter("@WORKERID", (object)existingLabourID));
            SqlCom.Parameters.Add(new SqlParameter("@IDProofFileName", (object)txtIDProofAttachment.Text));
            SqlCom.Parameters.Add(new SqlParameter("@ImageIDProof", streamIDProof.ToArray())); 
            SqlCom.Parameters.Add(new SqlParameter("@EnrollmentFileName", (object)txtEnrollmentAttachment.Text));
            SqlCom.Parameters.Add(new SqlParameter("@ImageEnrollment", streamEnrollment.ToArray()));
            SqlCom.Parameters.Add(new SqlParameter("@TradeCertificateFileName", (object)txtTradeCertificate.Text));
            SqlCom.Parameters.Add(new SqlParameter("@ImageTrade", streamTrade.ToArray()));
      
            cn.Open();
            SqlCom.ExecuteNonQuery();
            cn.Close();
            return 1;
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

        private void btnBrowseIDProof_Click(object sender, EventArgs e)
        {
            //opnAttachment.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";

            OpenFileIDProof.Title = "Select a PDF file";
            OpenFileIDProof.FileName = "";
            OpenFileIDProof.Multiselect = false;
            OpenFileIDProof.Filter = "PDF files|*.pdf";
            if (OpenFileIDProof.ShowDialog() == DialogResult.OK)
            {
                txtIDProofAttachment.Text = Convert.ToString(OpenFileIDProof.FileName);
                txtIDProofAttachment.Tag = Convert.ToString(OpenFileIDProof.FileName);
                btnBrowseIDProof.Enabled = true;
                btnOpenIDProof.Text = "Open";
                btnOpenIDProof.Visible = true;
            }
            else
            {
                txtIDProofAttachment.Text = "";
                txtIDProofAttachment.Tag = "";
                btnBrowseIDProof.Enabled = false;
                btnOpenIDProof.Visible = false;
            }
        }

        private void btnBrowseEnrollment_Click(object sender, EventArgs e)
        {
            OpenFileEntrollment.Title = "Select a PDF file";
            OpenFileEntrollment.FileName = "";
            OpenFileEntrollment.Multiselect = false;
            OpenFileEntrollment.Filter = "PDF files|*.pdf";
            if (OpenFileEntrollment.ShowDialog() == DialogResult.OK)
            {
                txtEnrollmentAttachment.Text = Convert.ToString(OpenFileEntrollment.FileName);
                txtEnrollmentAttachment.Tag = Convert.ToString(OpenFileEntrollment.FileName);
                btnBrowseEnrollment.Enabled = true;
                btnOpenEnrollment.Text = "Open";
                btnOpenEnrollment.Visible = true;
            }
            else
            {
                txtEnrollmentAttachment.Text = "";
                txtEnrollmentAttachment.Tag = "";
                btnBrowseEnrollment.Enabled = false;
                btnOpenEnrollment.Visible = false;
            }
        }

        private void btnBrowseTradeCertificate_Click(object sender, EventArgs e)
        {

            OpenFileTradeCertificate.Title = "Select a PDF file";
            OpenFileTradeCertificate.FileName = "";
            OpenFileTradeCertificate.Multiselect = false;
            OpenFileTradeCertificate.Filter = "PDF files|*.pdf";

            if (OpenFileTradeCertificate.ShowDialog() == DialogResult.OK)
            {
                txtTradeCertificate.Text = Convert.ToString(OpenFileTradeCertificate.FileName);
                txtTradeCertificate.Tag = Convert.ToString(OpenFileTradeCertificate.FileName);
                btnBrowseTradeCertificate.Enabled = true;
                btnOpenTradeCertificate.Visible = true;
                btnOpenTradeCertificate.Text = "Open";
            }
            else
            {
                txtTradeCertificate.Text = "";
                txtTradeCertificate.Tag = "";
                btnBrowseEnrollment.Enabled = false;
                btnOpenTradeCertificate.Visible = false;
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

        private void btnReUpload_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Re-Upload All Three Documents ?";
            string title = "Upload Query";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                int j = lab.ResetAttachments(existingLabourID);
                txtEnrollmentAttachment.Text = "";
                txtIDProofAttachment.Text = "";
                txtTradeCertificate.Text = "";
                btnOpenEnrollment.Text = "Open";
                btnOpenIDProof.Text = "Open";
                btnOpenTradeCertificate.Text = "Open";
                btnOpenTradeCertificate.Visible = false;
                btnOpenIDProof.Visible = false;
                btnOpenEnrollment.Visible = false;
                btnReUpload.Enabled = false;
                btnSave.Enabled = true;
                btnSave.Visible = true;
                btnBrowseEnrollment.Enabled = true;
                btnBrowseIDProof.Enabled = true;
                btnBrowseTradeCertificate.Enabled = true;
                lblStatus.Text = "Uploaded Files Removed. Upload New";
            }
        }

        private void btnCloseRejection_Click(object sender, EventArgs e)
        {
            panelRejection.Visible = false;
        }

        private void btnReSubmission_Click(object sender, EventArgs e)
        {
            int i = lab.UpdateLabourReSubmissionStatus(labourRollNumber);
            this.Close();
        }
    }
}
