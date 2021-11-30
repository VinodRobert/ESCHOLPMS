using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCHOLPMS.API.SpintlyUsers
{
    public class Pagination
    {
        public int total { get; set; }
        public int perPage { get; set; }
        public int currentPage { get; set; }
    }

    public class Role
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class ForAttendance
    {
        public int? userId { get; set; }
        public int orgUserId { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public bool isSignedUp { get; set; }
        public DateTime createdAt { get; set; }
        public bool cardAssigned { get; set; }
        public object accessExpiresAt { get; set; }
        public bool accessExpired { get; set; }
        public List<Role> roles { get; set; }
        public List<object> attributes { get; set; }
        public object deactivatedOn { get; set; }
        public string employeeCode { get; set; }
        public object reportees { get; set; }
        public object reportingTo { get; set; }
        public string credentialId { get; set; }
        public ForAttendance forAttendance { get; set; }
    }

    public class Message
    {
        public Pagination pagination { get; set; }
        public List<User> users { get; set; }
    }

    public class SpintlyUserLists
    {
        public string type { get; set; }
        public Message message { get; set; }
    }

}
