﻿using System;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace ThirteenDaysAWeek.Mvc4CustomErrorPage.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            throw new InvalidOperationException("Something very bad happened while doing important stuff");
        }

        public JsonResult GetData()
        {
            throw new JsonException("Some bad JSON thingy happened");
        }
    }
}
