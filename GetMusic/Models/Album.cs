using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetMusic.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ArtistId { get; set; }
        public double price { get; set; }
        public IEnumerable<Track> TracksId { get; set; }

    }
}