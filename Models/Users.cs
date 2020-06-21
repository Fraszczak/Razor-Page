using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageMovies.Models
{
    public class Users
    {
        public int ID { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Login { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Password { get; set; }
    }
}
