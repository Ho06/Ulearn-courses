﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ULearn.Controllers.Dashboard
{
    public class CategoryDashController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}