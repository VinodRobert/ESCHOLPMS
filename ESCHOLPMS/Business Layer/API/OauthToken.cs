using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace ESCHOLPMS.API.OauthToken
{
    public  class OauthTokenRequest
    {
            public string clientId { get; set; }
            public string clientSecret { get; set; }
            public string grantType { get; set; }
    }

  
    public class Payload
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string issued_token_type { get; set; }

    }
    public class Message
    {
        public Payload payload { get; set; }
        public int statusCode { get; set; }

    }
    public class OauthTokenResponse
{
        public string type { get; set; }
        public Message message { get; set; }

    }

}
