using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class OurTeamController : Controller
    {
        TravelContext travelContext=new TravelContext();
        // GET: OurTeam
        public ActionResult Index()
        {
            var values=travelContext.OurTeams.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddOurTeam()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddOurTeam(OurTeam ourTeam)
        {
            travelContext.OurTeams.Add(ourTeam);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTeamMember(int id)
        {
            var ourTeam = travelContext.OurTeams.Find(id);
            travelContext.OurTeams.Remove(ourTeam);
            travelContext.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult UpdateTeamMember(int id) 
        {
            var ourTeam = travelContext.OurTeams.Find(id);
            return View(ourTeam);
        }
        [HttpPost]
        public ActionResult UpdateTeamMember(OurTeam ourTeam)
        {
            var value = travelContext.OurTeams.Find(ourTeam.OurTeamID);
            value.Name = ourTeam.Name;
            value.Surname = ourTeam.Surname;
            value.Facebook = ourTeam.Facebook;
            value.Twitter = ourTeam.Twitter;
            value.Title = ourTeam.Title;
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}