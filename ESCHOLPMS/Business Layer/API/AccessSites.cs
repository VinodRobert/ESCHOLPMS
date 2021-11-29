using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ESCHOLPMS.API.AccessSites
{

    public class Sites
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

    public class Pagination
    {
        public int total { get; set; }
        public int perPage { get; set; }
        public int currentPage { get; set; }
    }

    public class Message
    {
        public IList<Sites> sites { get; set; }
        public Pagination pagination { get; set; }
    }

    public class AccessSites
    {
        public string type { get; set; }
        public Message message { get; set; }
    }

}
