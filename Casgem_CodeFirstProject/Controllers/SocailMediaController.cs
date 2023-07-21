using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class SocailMediaController : Controller
    {
        TravelContext travelContext=new TravelContext();
        // GET: SocailMedia
        public ActionResult Index()
        {
            var values=travelContext.SocialMedias.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            List<SelectListItem> values=(from x in travelContext.Guides.ToList()
                                        select new SelectListItem
                                        {
                                            Value=x.GuideID.ToString(),
                                            Text=x.GuideName
                                        }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            travelContext.SocialMedias.Add(socialMedia);
            travelContext.SaveChanges();
            return View();
        }
    }
}