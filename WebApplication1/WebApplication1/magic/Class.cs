using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.magic
{
    public class Mail
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("topic")]
        public string Topic { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

    }
}
