using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCHOLPMS.API.AccessPoints
{
    public class AccessPoint
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int siteId { get; set; }
    }

    public class Pagination
    {
        public int total { get; set; }
        public int perPage { get; set; }
        public int currentPage { get; set; }
    }

    public class Message
    {
        public List<AccessPoint> accessPoints { get; set; }
        public Pagination pagination { get; set; }
    }

    public class AccessPoints
    {
        public string type { get; set; }
        public Message message { get; set; }
    }


}
