﻿using Microsoft.AspNetCore.Mvc;

namespace FilmNetCoreUygulaması.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
