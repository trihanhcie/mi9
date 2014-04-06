using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MI9.Models
{

    public class Response
    {
        [JsonProperty(PropertyName = "response")]
        public List<ShowResponse> response { get; set; }
    }
}