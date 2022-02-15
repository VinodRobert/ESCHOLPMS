using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESCHOLPMS 
{
    public partial class frmNewLabour : Form
    {
        Int32 labourRollNumber;
        Labour lab = new Labour();

        public frmNewLabour(Int32 rollNumber)
        {
            labourRollNumber = rollNumber;
            InitializeComponent();
        }

        private void ReSetAll()
        {
            txtIDProofNumber.Text = "";
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
        }

        private void myEventHander(object sender,System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
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
            foreach (Control ctl in this.Controls)
            {
                ctl.KeyDown += myEventHander;
            }

            LoadStates();
            LoadSex();
            LoadBloodGroup();
            LoadJobType();
            LoadLabourType();
            LoadIDProof();
            LoadAccessCards();
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
        private void LoadLabour(Int32 who)
        {
             
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                
            }
        }
    }
}
