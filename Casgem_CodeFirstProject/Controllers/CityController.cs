using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class CityController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Cities.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCity()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCity(City city)
        {
            travelContext.Cities.Add(city);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCity(int id)
        {
            var city = travelContext.Cities.Find(id);
            travelContext.Cities.Remove(city);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCity(int id)
        {
            var city = travelContext.Cities.Find(id);
            return View(city);
        }

        [HttpPost]
        public ActionResult UpdateCity(City city)
        {
            var c = travelContext.Cities.Find(city.CityId);
            c.CityName = city.CityName;
            c.CityCount = city.CityCount;
            c.CityImageUrl = city.CityImageUrl;
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}