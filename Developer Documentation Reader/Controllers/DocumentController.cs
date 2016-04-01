using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Developer_Documentation_Reader.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        public ActionResult Index()
        {

            return View();
        }

        public string Welcome()
        {
            return "This is the welcome page.";
        }
    }
}