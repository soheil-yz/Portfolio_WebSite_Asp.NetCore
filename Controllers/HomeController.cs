﻿using DevCart.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;


namespace DevCart.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
		[HttpGet]
		public IActionResult Contact()
		{
			var model = new Contact();
			return View(model);
        }
        [HttpPost]
		public JsonResult Contact(Contact form)
		{
            Console.WriteLine(form.ToString());
			return Json(Ok());
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
