using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using MovieAngularJSApp2.Models;

namespace MovieAngularJSApp2.Controllers
{
    public class MoviesController : ApiController
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            var _session = HttpContext.Current.Session;

            _session["movie"] = "movies, movies, movies";

            return new List<Movie> {
                new Movie {Id=1, Title="Star Wars", Director="Lucas"},
                new Movie {Id=2, Title="King Kong", Director="Jackson"},
                new Movie {Id=3, Title="Memento", Director="Nolan"}
            };
        }
    }

}
