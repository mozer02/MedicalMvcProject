using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicalMvcProject.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        CurrentManager c = new CurrentManager();
        // GET: Current
        public ActionResult Index()
        {
            var model = c.GetCompany();
            return View(model);
        }
    }
}