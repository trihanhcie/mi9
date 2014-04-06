using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MI9.Models
{
    public class Request
    {
        public List<Payload> Payload { get; set; }
        public int? Skip { get; set; }
        public int? Take { get; set; }
        public int? TotalRecords { get; set; }
    }
}