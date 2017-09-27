using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetMusic.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public Album Album { get; set; }
    }
}