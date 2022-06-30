using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCHOLPMS  
{
    public class LabourDetails
    {
        public long LabourID { get; set; }
        public string LabourRollNo { get; set; }
        public int TempRollNumber { get; set; }
        public string LabourName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ParentName { get; set; }
        public string BloodGroup { get; set; }
        public string PermanantAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string State { get; set; }
        public string PINCode { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string IDProofSubmitted { get; set; }
        public string IDProofNumber { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string TypeOfLabour { get; set; }
        public string SkillType { get; set; }
        public string TypeOfJob { get; set; }
        public int SubContractorID { get; set; }
        public DateTime DateOfLeaving { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string Status { get; set; }
        public string TraderCertificateUpload { get; set; }
        public int CurrentCostCentreID { get; set; }
        public string AccessCardNumber { get; set; }

        public DateTime lastCheckInDate { get; set; }

        public int checkInCount { get; set; }

        public LabourDetails(long LabourID_, string LabourRollNo_, int TempRollNumber_, string LabourName_, string Gender_, DateTime DateOfBirth_, string ParentName_, string BloodGroup_, string PermanantAddress_, string CurrentAddress_, string State_, string PINCode_, string MobileNumber_, string PhoneNumber_, string IDProofSubmitted_, string IDProofNumber_, DateTime DateOfJoining_, string TypeOfLabour_, string SkillType_, string TypeOfJob_, int SubContractorID_, DateTime DateOfLeaving_, DateTime LastUpdateTime_, string Status_, string TraderCertificateUpload_, int CurrentCostCentreID_, string AccessCardNumber_)
        {
            this.LabourID = LabourID_;
            this.LabourRollNo = LabourRollNo_;
            this.TempRollNumber = TempRollNumber_;
            this.LabourName = LabourName_;
            this.Gender = Gender_;
            this.DateOfBirth = DateOfBirth_;
            this.ParentName = ParentName_;
            this.BloodGroup = BloodGroup_;
            this.PermanantAddress = PermanantAddress_;
            this.CurrentAddress = CurrentAddress_;
            this.State = State_;
            this.PINCode = PINCode_;
            this.MobileNumber = MobileNumber_;
            this.PhoneNumber = PhoneNumber_;
            this.IDProofSubmitted = IDProofSubmitted_;
            this.IDProofNumber = IDProofNumber_;
            this.DateOfJoining = DateOfJoining_;
            this.TypeOfLabour = TypeOfLabour_;
            this.SkillType = SkillType_;
            this.TypeOfJob = TypeOfJob_;
            this.SubContractorID = SubContractorID_;
            this.DateOfLeaving = DateOfLeaving_;
            this.LastUpdateTime = LastUpdateTime_;
            this.Status = Status_;
            this.TraderCertificateUpload = TraderCertificateUpload_;
            this.CurrentCostCentreID = CurrentCostCentreID_;
            this.AccessCardNumber = AccessCardNumber_;
        }
    }
}
