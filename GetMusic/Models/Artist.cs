using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetMusic.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Album> Albums { get; set; }

    }
}