using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MI9.Models
{
    public class Episode
    {
        public string Channel { get; set; }
        public string ChannelLogo { get; set; }
        public DateTime? Date { get; set; }
        public string Html { get; set; }
        public string Url { get; set; }
    }
}