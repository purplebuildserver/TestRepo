using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRepoLib;

namespace TestRepo.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/
        [HttpGet]
        public ActionResult Index()
        {
            return View("Index");
        }


        public ActionResult DoThing(string name)
        {
            ViewData["returnedString"] = new ThingDoer().DoThing(name);
            return View("Index");
            

        }
    }
}
