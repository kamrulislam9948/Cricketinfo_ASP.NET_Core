﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace M6_C8_P1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public   ActionResult Index()
        {
             return View();
        }
    }
}