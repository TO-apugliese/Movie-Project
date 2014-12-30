using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmParadies.Models
{
    public class Movie
    {
        [Key]
        public string imdbID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public DateTime Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public string TrailerUrl { get; set; }
        public DateTime BuyDate { get; set; }
        public DateTime LastWachted { get; set; }
        public bool PopcornCinema { get; set; }
    }
}