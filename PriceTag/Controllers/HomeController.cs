using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PriceTag.Models;

namespace PriceTag.Controllers
{
    public class HomeController : MyController
    {
        public IActionResult Index()
        {
            ViewBag.Items = InitData().Tables["Items"].Rows;
            return View();
        }
    }
}
