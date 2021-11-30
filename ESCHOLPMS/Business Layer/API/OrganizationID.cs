using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCHOLPMS.Business_Layer.API
{
   
        public class Message
        {
            public int organisationId { get; set; }
        }

        public class ResponseOrganizationID
        {
            public string type { get; set; }
            public Message message { get; set; }
        }
   
}
