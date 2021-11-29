using Syncfusion.Windows.Forms.Tools;
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

namespace ESCHOLPMS 
{
    public partial class frmEmployee : Form
    {
        Department _dep = new Department();
        Designation _des = new Designation();
        EmployeeMaster _emp = new EmployeeMaster();
        CostCentres _cs = new CostCentres();
        Ledgers _le = new Ledgers();
        AddressBook _adr = new AddressBook();
        EmployeeImages empImage = new EmployeeImages();
        PMS pms = new PMS();


        string photoFileName = String.Empty; 
        int employeeNumber, empAddressCode, salaryMasterCode;
        DataSet dsEmployee = new DataSet();
        DataSet dsDepartment = new DataSet();
        DataSet dsDesignation = new DataSet();
        DataSet dsCostCentre = new DataSet();
        DataSet dsHRStatus = new DataSet();
        DataSet dsBanks = new DataSet();

        public frmEmployee(int who)
        {
            InitializeComponent();
            employeeNumber = who;
            ResetAll();
        }

        private void LoadEmployeePhoto(int employeeID)
        {
            DataSet dsPicture = empImage.FetchPhoto(employeeID);
            if (dsPicture.Tables[0].Rows.Count==1)
            {
                Byte[] byteBLOBData = new Byte[0];
                byteBLOBData = (Byte[])(dsPicture.Tables[0].Rows[0]["PHOTO"]);
                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                picEmployee.Image = Image.FromStream(stmBLOBData);
            }
            else
            {
                picEmployee.Image = Image.FromFile("NOPHOTO.JPG");
            }
        }


        private void LoadDetails()
        {
            tabAccessControl.Enabled = true;
            tabAccountDetails.Enabled = true;
            tabAddress.Enabled = true;
            int employeeID;

            DataRow _dr = dsEmployee.Tables[0].Rows[0];
            txtEmployeeName.Text = Convert.ToString(_dr["EmployeeName"]);
            txtEmpID.Text = Convert.ToString(_dr["EmployeeNumber"]);
            employeeID = Convert.ToInt32(txtEmpID.Text);
            //   LoadEmployeePhoto(employeeID);
            dtJoinGrade.Value = Convert.ToDateTime(_dr["DateJoinGrade"]);
            dtJoinVettoor.Value = Convert.ToDateTime(_dr["DateJoinOrganization"]);
            dtDOB.Value = Convert.ToDateTime(_dr["DateOfBirth"]);
            cmbGender.Text = Convert.ToString(_dr["Sex"]);
            cmbBloodGroup.Text = _dr["BloodGroup"].ToString();

            cmbCostCentre.SelectedValue = Convert.ToInt32(_dr["CostCentreID"]);
            cmbDepartment.SelectedValue = Convert.ToInt32(_dr["DepartmentID"]);
            cmbDesignation.SelectedValue = Convert.ToInt32(_dr["DesignationID"]);

            txtPhone.Text = Convert.ToString(_dr["Mobile"]);
            txtEMailID.Text = Convert.ToString(_dr["Email"]);
            cmbCurrentStatus.SelectedValue = Convert.ToInt32(_dr["Status"]);
            txtAadharCard.Text = Convert.ToString(_dr["AadhaarNo"]);
            btnSave.Text = "Update";



            txtESINumber.Text = Convert.ToString(_dr["ESINumber"]);
            txtPAN.Text = Convert.ToString(_dr["PANNumber"]);
            txtPFNumber.Text = Convert.ToString(_dr["PFNumber"]);
            cmbBank.SelectedValue = Convert.ToInt32(_dr["BankID"]);
            txtAccountNumber.Text = Convert.ToString(_dr["BankAccountNumber"]);
            if (Convert.ToString(_dr["EligibleForPF"]) == "Y")
                chkPF.Checked = true;
            else
                chkPF.Checked = false;
            if (Convert.ToString(_dr["EligibleForESI"]) == "Y")
                chkESI.Checked = true;
            else
                chkESI.Checked = false;

            btnSaveAccountsDetails.Text = "Update";

            txtPermanentDistrict.Text = Convert.ToString(_dr["PermanentDistrict"]);
            txtPermanentHouse.Text = Convert.ToString(_dr["PermanentHouse"]);
            txtPermanentPIN.Text = Convert.ToString(_dr["PermanentPincode"]);
            txtPermanentState.Text = Convert.ToString(_dr["PermanentState"]);
            txtPermanentPlace.Text = Convert.ToString(_dr["PermanentPlace"]);
            txtPermanentPostOffice.Text = Convert.ToString(_dr["PermanentPostOffice"]);
            txtPermanentStreet.Text = Convert.ToString(_dr["PermanentStreet"]);

            txtPresentDistrict.Text = Convert.ToString(_dr["PresentDistrict"]);
            txtPresentHouse.Text = Convert.ToString(_dr["PresentHouse"]);
            txtPresentPIN.Text = Convert.ToString(_dr["PresentPincode"]);
            txtPresentPlace.Text = Convert.ToString(_dr["PresentPlace"]);
            txtPresentPostOffice.Text = Convert.ToString(_dr["PresentPostOffice"]);
            txtPresentState.Text = Convert.ToString(_dr["PresentState"]);
            txtPresentStreet.Text = Convert.ToString(_dr["PermanentStreet"]);
            btnSaveAddress.Text = "Update";




            //if (Convert.ToInt32(_dr["SalaryMasterCode"]) == 0)
            //{
            //    //rbtSalRevised.Checked = true;
            //    //pnlSalary.Enabled = true;
            //    //btnSavesalary.Text = "Save";
            //}
            //else
            //{
            //    salaryMasterCode = Convert.ToInt32(_dr["SalaryMasterCode"]);
            //    SalaryMaster _sm = new SalaryMaster();
            //    DataSet dsSalaryMaster = _sm.Fetch("*", "SalaryMasterCode =" + Convert.ToString(salaryMasterCode), null);
            //    if (dsSalaryMaster.Tables[0].Rows.Count != 0)
            //    {
            //        DataRow _drs = dsSalaryMaster.Tables[0].Rows[0];
            //        txtBasicDA.DecimalValue = Convert.ToDecimal(_drs["Basic_DA"]);
            //        txtDA.DecimalValue = Convert.ToDecimal(_drs["Da"]);
            //        txtHRA.DecimalValue = Convert.ToDecimal(_drs["Hra"]);
            //        txtOtherAllowance.DecimalValue = Convert.ToDecimal(_drs["OtherAllowance"]);

            //        txtTakeHomeSalary.DecimalValue = Convert.ToDecimal(_drs["TakeHomeSalary"]);
            //        txtGrossSalary.DecimalValue = Convert.ToDecimal(_drs["GrossSalary"]);
            //        btnSaveSalary.Text = "Update";
            //    }

            //}
        }

        private void ResetAll()
        {
            txtEMailID.Text = "";
            txtEmpID.Text = "";
            txtEmployeeName.Text = "";
            txtPhone.Text = "";
            txtAadharCard.Text = "";


            txtPAN.Text = "";
            chkPF.Checked = false;
            txtPFNumber.Text = "";
            chkESI.Checked = false;
            txtAccountNumber.Text = "";
            txtPermanentHouse.Text = "";
            txtPermanentStreet.Text = "";
            txtPermanentPostOffice.Text = "";
            txtPermanentPlace.Text = "";
            txtPermanentDistrict.Text = "";
            txtPermanentState.Text = "";
            txtPermanentPIN.Text = "";
            txtPresentHouse.Text = "";
            txtPresentStreet.Text = "";
            txtPresentPostOffice.Text = "";
            txtPresentPlace.Text = "";
            txtPresentDistrict.Text = "";
            txtPresentState.Text = "";
            txtPresentPIN.Text = "";

            

            this.tabEmployee.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRenderer3D);
            this.tabEmployee.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.OneNoteStyleRenderer);
            this.tabEmployee.BorderVisible = true;
            this.tabEmployee.BorderWidth = 10;


            this.dtDOB.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.dtDOB.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtDOB.Format = "dd/MM/yyyy";

            this.dtJoinGrade.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.dtJoinGrade.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtJoinGrade.Format = "dd/MM/yyyy";

            this.dtJoinVettoor.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.dtJoinVettoor.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.dtJoinVettoor.Format = "dd/MM/yyyy";

            tabAccessControl.Enabled = false;
            tabAccountDetails.Enabled = false;
            tabAddress.Enabled = false;
            
        }


        private void frmEmployee_Load(object sender, EventArgs e)
        {
           
            LoadDepartment();
            LoadCostCentre();
            LoadHRStatus();
            LoadGender();
            LoadBloodGroups();
            LoadBankAccount();
            if (employeeNumber == 0)
            {
                dtDOB.Value = DateTime.Today;
                dtJoinGrade.Value = DateTime.Today;
                dtJoinVettoor.Value = DateTime.Today;
            }
          
            if (employeeNumber != 0)
            {
                dsEmployee = pms.FetchEmployeeDetails(employeeNumber);
                LoadDetails();
                btnSaveBasicDetails.Text = "Update";
            }
            else
            {
                tabEmployee.Enabled = false;
                tabEmployee.Visible = false;
                txtEmpID.Text = "0";
                txtEmployeeName.Text = "";
                btnSave.Text = "Save";
            }
            
         
        }

        private void LoadBankAccount()
        {
            dsBanks = pms.FetchBankLedgers();
            cmbBank.DataSource = dsBanks.Tables[0];
            cmbBank.Refresh();
        }

        private void LoadGender()
        {
            string[] sex = { "Male", "Female"  };
            List<string> sexList = new List<string>(sex);
            cmbGender.DataSource = sexList;
        }

        private void LoadBloodGroups()
        {
            string[] blood = { "O+", "A+", "B+", "AB+", "O-", "AB-" };
            List<string> bloodList = new List<string>(blood);
            cmbBloodGroup.DataSource = bloodList;


        }

        private void LoadDepartment()
        { 
            dsDepartment = pms.FetchDepartment();
            cmbDepartment.DataSource = dsDepartment.Tables[0];
            cmbDepartment.Text = "Select Dept";
             
        }
        private void LoadCostCentre()
        {
            dsCostCentre = pms.fetchCostCentre();
            cmbCostCentre.DataSource = dsCostCentre.Tables[0];
            cmbCostCentre.Text = "Select CostCentre";
        }

        private void LoadHRStatus()
        {
            dsHRStatus = pms.FetchHRStatus();
            cmbCurrentStatus.DataSource = dsHRStatus.Tables[0];
            cmbCurrentStatus.Text = "Select Status";
        }
    
   

        private void LoadDesignation()
        {
            dsDesignation = pms.FetchDesignation();
            cmbDesignation.DataSource = dsDesignation.Tables[0];
            cmbDesignation.Text = "Select Desig";
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDesignation();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validEntry()
        {
            if (txtEmployeeName.Text.Trim() == "")
                return false;
            if (cmbDepartment.SelectedItems.Count == 0)
                return false;
            if (cmbDesignation.SelectedItems.Count == 0)
                return false;
            if (cmbCostCentre.SelectedItems.Count == 0)
                return false;
            else
                return true;
        }


        private void btnSaveBasicDetails_Click(object sender, EventArgs e)
        {
            if (btnSaveBasicDetails.Text=="Update")
            {
                if (validEntry())
                {
                    _emp.EmployeeCode = Convert.ToInt32(employeeNumber);
                    _emp.Import();
                    _emp.EmployeeName = txtEmployeeName.Text.Trim();
                    _emp.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                    _emp.DesignationID = Convert.ToInt32(cmbDesignation.SelectedValue);
                    _emp.DateOfBirth = Convert.ToDateTime(dtDOB.Value);
                    _emp.DateJoinOrganization = Convert.ToDateTime(dtJoinVettoor.Value);
                    _emp.DateJoinGrade = Convert.ToDateTime(dtJoinGrade.Value);
                    _emp.Status = Convert.ToInt32(cmbCurrentStatus.SelectedValue);
                    _emp.Sex = Convert.ToString(cmbGender.Text);
                    _emp.BloodGroup = Convert.ToString(cmbBloodGroup.Text);
                    _emp.LandLine = Convert.ToString(txtPhone.Text.Trim());
                    _emp.Mobile = Convert.ToString(txtPhone.Text.Trim());
                    _emp.Email = Convert.ToString(txtEMailID.Text.Trim());
                    _emp.CostCentreID = Convert.ToInt32(cmbCostCentre.SelectedValue);
                    //_emp.PhotoFileName = Convert.ToString(_path);
                    _emp.AadhaarNo = Convert.ToString(txtAadharCard.Text);
                    _emp.Update();
                    MessageBox.Show("Basic Data Updated Successfully !!!");
                }
            }
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPageAdv item;
            item = this.tabEmployee.SelectedTab;
            if (item.Text=="Accounts Details")
            {
                tabAccountDetails.Enabled = true;
                tabAddress.Enabled = false;
            }
            if (item.Text == "Address")
            {
                tabAccountDetails.Enabled = true;
                tabAddress.Enabled = true;
            }

            if (item.Text == "Salary Details")
            {
                tabAccountDetails.Enabled = false;
                tabAddress.Enabled = false;
                tabSalaryDetails.Enabled = true;
            }

        }

        private void tabAccountDetails_Click(object sender, EventArgs e)
        {
            tabAccountDetails.Enabled = true;
            
        }

        private void btnSaveSalary_Click(object sender, EventArgs e)
        {
            SalaryMaster _sm = new SalaryMaster();
            _sm.SalaryMasterCode = salaryMasterCode;
            _sm.Import();
            _sm.EmpID = employeeNumber;
            _sm.Basic_DA = Convert.ToDecimal(txtBasicDA.DecimalValue);
            _sm.Da = Convert.ToDecimal(txtDA.DecimalValue);
            _sm.Hra = Convert.ToDecimal(txtHRA.DecimalValue);
            _sm.OtherAllowance = Convert.ToDecimal(txtOtherAllowance.DecimalValue);
            _sm.TakeHomeSalary = Convert.ToDecimal(txtTakeHomeSalary.DecimalValue);
            _sm.GrossSalary = Convert.ToDecimal(txtGrossSalary.DecimalValue);
            _sm.StatusCode = 0;
            _sm.Update();
            UtilityFunctions.Success();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
           
            int who = Convert.ToInt32(txtEmpID.Text);
            if (btnBrowse.Text == "Browse")
            {
                OpenFileDialog open = new OpenFileDialog();
                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    picPerson.Image = new Bitmap(open.FileName);
                    // image file path  
                    lblFileName.Text = open.FileName;
                    photoFileName = lblFileName.Text;
                }
                btnBrowse.Text = "Update";
            }
            else
            {
                if (photoFileName.Length != 0)
                {
                    empImage.InsertEmployeePhoto(who, photoFileName);
                    picEmployee.Image = Image.FromFile(photoFileName);
                    UtilityFunctions.Success();
                }
                else
                {
                    MessageBox.Show("Check File Name");
                    return;
                }

         
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text=="Save")
            {
                _emp = new EmployeeMaster();
                _emp.EmployeeCode = 0;
                _emp.Import();
                _emp.EmployeeName = Convert.ToString(txtEmployeeName.Text).Trim();
                _emp.AadhaarNo = "0";
                _emp.BankAccountNumber = "0";
                _emp.DateJoinOrganization= DateTime.Now;
                _emp.DateJoinOrganization = DateTime.Now;
             

                _emp.Update();
                employeeNumber = _emp.EmployeeCode;
              //  txtEmployeeCode.Text = Convert.ToString(_employeeNumber);

            }
        }

        private void btnSaveAccountsDetails_Click(object sender, EventArgs e)
        {
            if (btnSaveAccountsDetails.Text == "Save")
            {
                _emp.EmployeeCode = Convert.ToInt32(employeeNumber);
                _emp.Import();
                _emp.PANNumber = txtPAN.Text.Trim();
                _emp.PFNumber = txtPFNumber.Text.Trim();
                _emp.ESINumber = txtESINumber.Text.Trim();
                _emp.BankID = Convert.ToInt32(cmbBank.SelectedValue);
                _emp.BankAccountNumber = txtAccountNumber.Text.Trim();
                if (chkPF.Checked == true)
                  _emp.EligibleForPF = "Y";  
                else
                  _emp.EligibleForPF = "N";    
                
                if (chkESI.Checked == true)
                  _emp.EligibleForESI = "Y";  
                else
                  _emp.EligibleForESI = "N";  

                _emp.Update();
                btnSaveAccountsDetails.Enabled = false;
                tabAddress.Show();
            }
            else if (btnSaveAccountsDetails.Text == "Update")
            {
                _emp.EmployeeCode = Convert.ToInt32(employeeNumber);
                _emp.Import();
                _emp.PANNumber = txtPAN.Text.Trim();
                _emp.PFNumber = txtPFNumber.Text.Trim();
                _emp.ESINumber = txtESINumber.Text.Trim();
                _emp.BankID = Convert.ToInt32(cmbBank.SelectedValue);
                _emp.BankAccountNumber = txtAccountNumber.Text.Trim();
                if (chkPF.Checked == true)
                  _emp.EligibleForPF = "Y";  
                else
                  _emp.EligibleForPF = "N";  
                if (chkESI.Checked == true)
                  _emp.EligibleForESI = "Y";  
                else
                 _emp.EligibleForESI = "N";     
                _emp.Update();
                 btnSaveAccountsDetails.Enabled = false;
                tabAddress.Show();
            }
            UtilityFunctions.Success();
        }

        private void btnSaveAddress_Click(object sender, EventArgs e)
        {
            if (btnSaveAddress.Text == "Save")
            {
                if (employeeNumber != 0)
                {
                    _adr = new AddressBook();
                    _adr.AddressCode = 0;
                    _adr.PermanentHouse = txtPermanentHouse.Text.Trim();
                    _adr.PermanentStreet = txtPermanentStreet.Text.Trim();
                    _adr.PermanentDistrict = txtPermanentDistrict.Text.Trim();
                    _adr.PermanentPlace = txtPermanentPlace.Text.Trim();
                    _adr.PermanentState = txtPermanentState.Text.Trim();
                    _adr.PermanentPostOffice = txtPermanentPostOffice.Text.Trim();
                    _adr.PermanentPincode = txtPermanentPIN.Text.Trim();


                    _adr.PresentDistrict = txtPresentDistrict.Text.Trim();
                    _adr.PresentHouse = txtPresentHouse.Text.Trim();
                    _adr.PresentPincode = txtPresentPIN.Text.Trim();
                    _adr.PresentPlace = txtPresentPlace.Text.Trim();
                    _adr.PresentPostOffice = txtPresentPostOffice.Text.Trim();
                    _adr.PresentState = txtPresentState.Text.Trim();
                    _adr.PresentStreet = txtPresentStreet.Text.Trim();

                    _adr.Update();
                    _adr.Import();
                    empAddressCode = _adr.AddressCode;
                    _emp.EmployeeCode = employeeNumber;
                    _emp.Import();
                    _emp.AddressID = Convert.ToInt32(empAddressCode);
                    _emp.Update();

                    btnSaveAddress.Enabled = false;
                }
            }
            else if (btnSaveAddress.Text == "Update")
            {
                _adr = new AddressBook();
                _adr.AddressCode = Convert.ToInt32(empAddressCode);
                _adr.PermanentHouse = txtPermanentHouse.Text.Trim();
                _adr.PermanentStreet = txtPermanentStreet.Text.Trim();
                _adr.PermanentDistrict = txtPermanentDistrict.Text.Trim();
                _adr.PermanentPlace = txtPermanentPlace.Text.Trim();
                _adr.PermanentState = txtPermanentState.Text.Trim();
                _adr.PermanentPostOffice = txtPermanentPostOffice.Text.Trim();
                _adr.PermanentPincode = txtPermanentPIN.Text.Trim();

                _adr.PresentDistrict = txtPresentDistrict.Text.Trim();
                _adr.PresentHouse = txtPresentHouse.Text.Trim();
                _adr.PresentPincode = txtPresentPIN.Text.Trim();
                _adr.PresentPlace = txtPresentPlace.Text.Trim();
                _adr.PresentPostOffice = txtPresentPostOffice.Text.Trim();
                _adr.PresentState = txtPresentState.Text.Trim();
                _adr.PresentStreet = txtPresentStreet.Text.Trim();

                _adr.Update();
                _adr.Import();
                empAddressCode = _adr.AddressCode;
                _emp.EmployeeCode = employeeNumber;
                _emp.Import();
                _emp.AddressID = Convert.ToInt32(empAddressCode);
                _emp.Update();
                btnSaveAddress.Enabled = false;
            }
            UtilityFunctions.Success();
        }
    }
}
