using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ePortfolio.Controllers
{
    public class LabsController : Controller
    {
        // GET: Labs
        public ActionResult Index()
        {
            return View();
        }

        // GET: Labs
        public ActionResult Terminal()
        {
            return View();
        }
    }
}
