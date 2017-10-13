using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZenithSociety.Models;

namespace ZenithSociety.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var events = db.Events.Include(e => e.ActivityCategory).ToList();
            // 1 offset for start in Monday     
            int mondayOffset = (((int)DateTime.Today.DayOfWeek) > 0) ? 1 - ((int)DateTime.Today.DayOfWeek) : 1 - 7;
            DateTime first = DateTime.Today.AddDays(mondayOffset);
            DateTime last = first.AddDays(7);
            List<Event> eventsOfWeek = new List<Event>();

            foreach (Event eve in events)
            {
                if (eve.EventFromDate.Date.CompareTo(first.Date) >= 0 && eve.EventFromDate.Date.CompareTo(last.Date) < 0)
                {
                    eventsOfWeek.Add(eve);
                }
            }
            return View(eventsOfWeek.OrderBy(e => e.EventFromDate).ToList());

            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}