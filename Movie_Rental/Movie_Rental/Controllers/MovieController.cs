using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_Rental.Models;

namespace Movie_Rental.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult table(int id)
        {
            var a = new Movie() { Id = id };   
            return View(a);
        }
    }
}