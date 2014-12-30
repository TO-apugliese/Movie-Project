using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmParadies.Models
{
    public class Star
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string BornCity { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public List<Movie> Movies { get; set; }
    }
}