using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyTutorial.Models;

namespace VidlyTutorial.Controllers
{
    public class MoviesController : Controller
    {//derives from Controller Class
        // GET: Movies/Random (Class and movies controller)... ActionResult is the action, Random.
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek!" };

            return View(movie);
        }
    }
}

//This is EventHandlerTaskAsyncHelper controller for Movies and it also contains the code that calls the Random view