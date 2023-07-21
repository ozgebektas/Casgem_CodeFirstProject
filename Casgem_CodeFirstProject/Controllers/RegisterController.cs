using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class RegisterController : Controller
    {
        TravelContext travelContext = new TravelContext();

        // GET: Register
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        { 
            travelContext.Admins.Add(admin);
            travelContext.SaveChanges();
            return View("Index","Login");

        }
    }
}