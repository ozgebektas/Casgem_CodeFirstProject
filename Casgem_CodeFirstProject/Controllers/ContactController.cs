using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class ContactController : Controller
    {
        TravelContext travelContext=new TravelContext();
        // GET: Contact

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.email = travelContext.Contacts.Select(x => x.Mail).FirstOrDefault();
            ViewBag.phone=travelContext.Contacts.Select(x=>x.Subject).FirstOrDefault();
            ViewBag.Message=travelContext.Contacts.Select(x=>x.Message).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            travelContext.Contacts.Add(contact);
            travelContext.SaveChanges();
        
            return View("Index");
        }
    }
}