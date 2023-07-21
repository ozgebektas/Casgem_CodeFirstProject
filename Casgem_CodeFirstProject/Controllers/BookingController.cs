using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
      
        public class BookingController : Controller
        {
            TravelContext travelContext = new TravelContext();
            // GET: Booking
            public ActionResult Index()
            {
                var values = travelContext.Bookings.Where(x => x.BookingStatus == "Aktif").ToList();
                return View(values);
            }

            public ActionResult DeleteBooking(int id)
            {
                var booking = travelContext.Bookings.Find(id);
                booking.BookingStatus = "Pasif";
                travelContext.SaveChanges();
                return RedirectToAction("Index");
            }
       
            [HttpGet]
            public ActionResult UpdateBooking(int id)
            {
                var b = travelContext.Bookings.Find(id);
                return View(b);
            }

            [HttpPost]
            public ActionResult UpdateBooking(Booking booking)
            {
                var b = travelContext.Bookings.Find(booking.BookingID);
                b.CustomerName = booking.CustomerName;
                b.Destination = booking.Destination;
                b.Duration = booking.Duration;
                b.BookingDate = booking.BookingDate;
                travelContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
