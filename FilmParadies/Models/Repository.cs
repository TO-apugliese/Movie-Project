using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmParadies.Models
{
    public class Repository
    {
        public List<Movie> GetMovies() {
            //List<Movie> myMovies = new List<Movie>()
            //{
            //    new Movie(){
            //        ID = 0,
            //        Title = "Der Herr der Ringe die Gefährten",
            //        Description = "lorem Ipsum",
            //        Runtime = 240,
            //        Genre = Enums.Genre.Fantasy.ToString(),
            //        Director = "Peter Jackson",
            //        ReleaseDate = DateTime.Parse("2002-02-02 00:00:00"),
            //        coverImgUrl = "http://test.de",
            //        TrailerUrl = "http://test.de/youtube",
            //        LastWachted = DateTime.Parse("2014-11-28 00:00:00"),
            //        BuyDate = DateTime.Parse("2012-06-21 00:00:00"),
            //        PopcornCinema = false             
            //    },

            //    new Movie(){
            //        ID = 1,
            //        Title = "Der Herr der Ringe die zwei Türme",
            //        Description = "lorem Ipsum",
            //        Runtime = 245,
            //        Genre = Enums.Genre.Fantasy.ToString(),
            //        Director = "Peter Jackson",
            //        ReleaseDate = DateTime.Parse("2003-02-02 00:00:00"),
            //        coverImgUrl = "http://test.de",
            //        TrailerUrl = "http://test.de/youtube",
            //        LastWachted = DateTime.Parse("2014-12-05 00:00:00"),
            //        BuyDate = DateTime.Parse("2012-06-21 00:00:00"),
            //        PopcornCinema = false             
            //    },

            //    new Movie(){
            //        ID = 2,
            //        Title = "Der Herr der Ringe die Rückkehr des Königs",
            //        Description = "lorem Ipsum",
            //        Runtime = 250,
            //        Genre = Enums.Genre.Fantasy.ToString(),
            //        Director = "Peter Jackson",
            //        ReleaseDate = DateTime.Parse("2004-02-02 00:00:00"),
            //        coverImgUrl = "http://test.de",
            //        TrailerUrl = "http://test.de/youtube",
            //        LastWachted = DateTime.Parse("2014-12-11 00:00:00"),
            //        BuyDate = DateTime.Parse("2012-06-21 00:00:00"),
            //        PopcornCinema = false             
            //    }
            //};

            return null;
        }

        public Star GetStarByID(int id) {
            return null;
        }
    }
}