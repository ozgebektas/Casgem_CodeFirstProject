using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AdminController : Controller
    {            TravelContext travelContext = new TravelContext();

            public ActionResult Index()
            {
                return View();
            }

            public ActionResult AdminList()
            {
                var admins = travelContext.Admins.ToList();
                return View(admins);
            }

            [HttpGet]
            public ActionResult AddAdmin()
            {
                return View();
            }
            [HttpPost]
            public ActionResult AddAdmin(Admin admin)
            {
                travelContext.Admins.Add(admin);
                travelContext.SaveChanges();
                return RedirectToAction("AdminList");
            }


            public ActionResult DeleteAdmin(int id)
            {
                var adm = travelContext.Admins.Find(id);
                travelContext.Admins.Remove(adm);
                travelContext.SaveChanges();
                return RedirectToAction("AdminList");
            }

            [HttpGet]
            public ActionResult UpdateAdmin(int id)
            {
                var adm = travelContext.Admins.Find(id);
                return View(adm);
            }
            [HttpPost]
            public ActionResult UpdateAdmin(Admin admin)
            {
                var adm = travelContext.Admins.Find(admin.AdminID);
                adm.Username = admin.Username;
                adm.Password = admin.Password;
                travelContext.SaveChanges();
                return RedirectToAction("AdminList");
            }
        }
    }
