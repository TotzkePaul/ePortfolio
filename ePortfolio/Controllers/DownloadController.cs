﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ePortfolio.Controllers
{
    public class DownloadController : Controller
    {
        // GET: Download
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return Content("null");
            }
            else
            {
                return Content(id.ToString());
            }
            
        }
    }
}