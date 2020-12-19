using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Skopje_charging_stations.Models;

namespace Skopje_charging_stations.Controllers
{
    [Authorize]
    public class charging_stationController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: charging_station
        public ActionResult Index()
        {
            return View(db.charging_station.ToList());
        }
        public ActionResult TabularView()
        {
            return View(db.charging_station.ToList());
        }
        // GET: charging_station/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            charging_station charging_station = db.charging_station.Find(id);
            if (charging_station == null)
            {
                return HttpNotFound();
            }
            return View(charging_station);
        }
        public ActionResult Detali(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            charging_station charging_station = db.charging_station.Find(id);
            if (charging_station == null)
            {
                return HttpNotFound();
            }
            return View(charging_station);
        }
        public ActionResult Map()
        {
            return View(db.charging_station.ToList());
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
