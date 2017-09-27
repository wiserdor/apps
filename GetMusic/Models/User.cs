using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetMusic.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public IEnumerable<Album> Purchases { get; set; }

    }
}