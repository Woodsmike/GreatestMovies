using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreatestMovies.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

    }
}