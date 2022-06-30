using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCHOLPMS.Business_Layer.API
{
    public  class SpintlyUserForUpload
    {
        public IList<SingleUser> users { get; set; }
    }

    public class SingleUser 
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public IList<int> roles { get; set; }
        public bool gps { get; set; }
        public bool deviceLock { get; set; }
        public bool mobile { get; set; }
        public bool proximityAccess { get; set; }
        public bool card { get; set; }
        public bool fingerprint { get; set; }
        public bool remoteAccess { get; set; }
        public string clickToAccessRange { get; set; }
        public DateTime accessExpiresAt { get; set; }
        public bool tapToAccess { get; set; }
        public IList<int> accessPoints { get; set; }
        public string employeeCode { get; set; }
        public IList<int> reportingTo { get; set; }
        public int probationPeriod { get; set; }
        public string joiningDate { get; set; }
        public string gender { get; set; }
        public Int64 credentialId { get; set; }

    }


    public class MessageNewUserList
    {
        public List<int> userIds { get; set; }
    }

    public class ResponseSingleUserCreation
    {
        public string type { get; set; }
        public MessageNewUserList message { get; set; }
    }


}
