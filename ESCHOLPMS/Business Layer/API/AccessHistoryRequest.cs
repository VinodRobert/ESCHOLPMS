using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCHOLPMS.API.AccessHistoryRequest
{
 
    public class Pagination
    {
        public int page { get; set; }
        public int perPage { get; set; }
    }

    public class S
    {
        public string employeeId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }

    public class Filters
    {
        public List<int> accessPoints { get; set; }
        public int reportingManager { get; set; }
        public List<int> roles { get; set; }
        public List<int> terms { get; set; }
        public List<int> users { get; set; }
        public string direction { get; set; }
        public List<string> accessTypes { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public S s { get; set; }
    }

    public class AccessHistoryRequest
    {
        public Pagination pagination { get; set; }
        public Filters filters { get; set; }
    }

}
