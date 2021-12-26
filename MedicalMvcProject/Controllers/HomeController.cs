using BusinessLayer.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicalMvcProject.Controllers
{
    public class HomeController : Controller
    {
        CurrentManager c = new CurrentManager();
        // GET: Home
        public ActionResult Index()
        {
            //List<EmployeeDetail> a = c.GetPersonel();
            //string b = a[0].Currents.Adress1;
            return View();
        }

    }
}