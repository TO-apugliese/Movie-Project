using FilmParadies.Models;
using FilmParadies.Models.ReciveModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace FilmParadies.Controllers
{
    public class DataController : Controller
    {
        //
        // GET: /Data/

        static string _address = "http://www.omdbapi.com";
        private Movie saveResult;
        private string jsonResult;


        //
        // Post: /Movie/
        [HttpPost]
        public ActionResult ConvertLogInfoToXml(string result)
        {
            result += "\"}";
            Movie newMovie = Deserialize(result);
            

            return View();
        }

        public Movie Deserialize(string json) {

            return new JavaScriptSerializer().Deserialize<Movie>(json); ;
        }
    }
}
