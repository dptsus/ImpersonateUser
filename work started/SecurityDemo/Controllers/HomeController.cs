﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityDemo.Controllers
{
    //[Authorize(Roles = "superadmin")]//[Authorize(user = "superadmin")]
    public class HomeController : Controller
    {
        //yogesh till 4 pm
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}