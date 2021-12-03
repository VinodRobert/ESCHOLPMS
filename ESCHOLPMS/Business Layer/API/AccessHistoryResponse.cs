using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCHOLPMS.API.AccessHistoryResponse
{
  
    public class Pagination
    {
        public int perPage { get; set; }
        public int total { get; set; }
        public int currentPage { get; set; }
    }

    public class Term
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Attribute
    {
        public int id { get; set; }
        public string attributeName { get; set; }
        public List<Term> terms { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string employeeCode { get; set; }
        public List<Attribute> attributes { get; set; }
    }

    public class AccessPoint
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public bool forAttendance { get; set; }
        public bool forAaccess { get; set; }
    }

    public class AccessHistory
    {
        public int id { get; set; }
        public Int64 accessorId { get; set; }
        public Int64 accessedAt { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string direction { get; set; }
        public string accessType { get; set; }
        public string createdAt { get; set; }
        public string mobileAccessMode { get; set; }
        public User user { get; set; }
        public AccessPoint accessPoint { get; set; }
    }

    public class Message
    {
        public Pagination pagination { get; set; }
        public List<AccessHistory> accessHistory { get; set; }
    }

    public class AccessHistoryResponse
    {
        public string type { get; set; }
        public Message message { get; set; }
    }


}
