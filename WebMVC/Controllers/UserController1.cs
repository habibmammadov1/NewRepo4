﻿using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
