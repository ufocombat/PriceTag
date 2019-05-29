using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PriceTag.Models;
using FastReport;
using FastReport.Web;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace PriceTag.Controllers
{
    public class HomeController : MyController
    {
        private IHostingEnvironment _env;

        public HomeController(IHostingEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            ViewBag.Items = InitData().Tables["Items"].Rows;
            return View();
        }

        public IActionResult PrintTags()
        {
            WebReport webReport = new WebReport();
            webReport.Width = "100%";

            DataSet d = InitData();

            webReport.Report.Load(System.IO.Path.Combine(_env.WebRootPath + "/reports", "tags.frx"));
            webReport.Report.RegisterData(d, "ItemsDataSet");
            webReport.Report.GetDataSource("Items").Enabled = true;
            (webReport.Report.FindObject("Data1") as DataBand).DataSource = webReport.Report.GetDataSource("Items");
            webReport.Report.Prepare();

            ViewBag.WebReport = webReport;

            return View();
        }
    }
}
