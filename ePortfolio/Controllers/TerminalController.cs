using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ePortfolio.Controllers
{
    public class TerminalController : Controller
    {
        // GET: Terminal
        public ActionResult Index()
        {
            return View();
        }

        // GET: Terminal/Edit/5
        public ActionResult RunCommand(String input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed =  new string(charArray);
            return Content(reversed);
        }

        // POST: Terminal/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


        //// GET: Terminal/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Terminal/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Terminal/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}



        //// GET: Terminal/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Terminal/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
