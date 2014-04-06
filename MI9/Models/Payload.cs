using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MI9.Models
{
    public class Payload
    {
        public string Country { get; set; }
        public string Descripion { get; set; }
        public bool? DRM { get; set; }
        public int? EpisodeCount { get; set; }
        public string Genre { get; set; }
        public Image Image { get; set; }
        public string Language { get; set; }
        public Episode NextEpisode { get; set; }
        public string PrimaryColor { get; set; }
        public List<Season> Seasons { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string TVChannel { get; set; }
    }
}