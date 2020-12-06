using Skopje_charging_stations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Skopje_charging_stations.Controllers
{
    public class csController : Controller
    {
        // GET: cs
        public static List<charging_station> csList = new List<charging_station>()
        {
            new charging_station(){id=0,longitude=21.4275923,latitude=41.9921300,amenity="charging_station",fee="no",openingHours="24/7",operatorCS="EVN",socket="22kW",tip="Wallbe Pro",address="Sv. Kiril i Metodij 18  Skopje 1000",municipality="Centar"},
            new charging_station(){id=1,longitude=21.4651780,latitude=41.986714,amenity="charging_station",fee="no",openingHours="24/7",operatorCS="EVN",socket="22kW",tip="Wallbe Pro",address="Boulevar Jane Sandanski 35  Skopje 1000",municipality="Aerodrom"},
            new charging_station(){id=2,longitude=21.4035307,latitude=42.0136336,amenity="charging_station",fee="no",openingHours="24/7",operatorCS="EVN",socket="22kW",tip="Wallbe Pro Plus",address="Skupi 5a  Skopje 1000",municipality="Centar"},
            new charging_station(){id=3,longitude=21.4322161,latitude=41.9948629,amenity="charging_station",fee="no",openingHours="24/7",operatorCS="EVN",socket="22kW",tip="Wallbe Pro",address="bul. 11 Oktomvri br. 9 Skopje 1000 MK",municipality="Centar" },
            new charging_station(){id=4,longitude=21.3632349,latitude=42.0091302,amenity="charging_station",fee="no",openingHours="24/7",operatorCS="EVN",socket="22kW",tip="Wallbe Pro Plus",address="Partizanski Odredi Skopje 1000",municipality="Gjorche Petrov" },
            new charging_station(){id=5,longitude=21.4180965,latitude=42.0053710,amenity="charging_station",fee="no",openingHours="24/7",operatorCS="EVN",socket="22kW",tip="Wallbe Pro",address="Albert Einstein 83  Skopje 1000",municipality="Centar"},
            new charging_station(){id=6,longitude=21.4269103,latitude=42.0061889,amenity="charging_station",fee="no",openingHours="24/7",operatorCS="EVN",socket="22kW",tip="Wallbe Pro",address="1732 br.4  Skopje 1000",municipality="Centar"},
            new charging_station(){id=7,longitude=21.3724961,latitude=42.0067912,amenity="charging_station",fee="no",openingHours="24/7",operatorCS="EVN",socket="22kW",tip="Wallbe Pro Plus",address="Delfina Square Mramorec Nr 8a MK Skopje 1000",municipality="Karposh" },
            new charging_station(){id=8,longitude=21.4870891,latitude=42.0070408,amenity="charging_station",fee="no",openingHours="24/7",operatorCS="EVN",socket="22kW",tip="Wallbe Pro Plus",address="Edvard Kardelj/Aleksandar Makedonski Madzhari",municipality="Gazi Baba" },
            new charging_station(){id=9,longitude=21.4192586,latitude=42.0048405,amenity="charging_station",fee="no",openingHours="24/7",operatorCS="EVN",socket="22kW",tip="Wallbe Pro",address="Bulevar Ilinden 82 Assembly of the City of Skopje",municipality="Centar" },
            new charging_station(){id=10,longitude=21.4775368,latitude=41.9887319,amenity="charging_station",fee="no",openingHours="24/7",operatorCS="EVN",socket="22kW",tip="Wallbe Pro Plus",address="Double Tree By Hilton Kej na Vardar Parking Hotel MK Skopje 1000",municipality="Aerodrom" },
            new charging_station(){id=11,longitude=21.4119700,latitude=41.9947319,amenity="charging_station",fee="no",openingHours="24/7",operatorCS="EVN",socket="22kW",tip="Wallbe Pro Plus",address="Naroden Front Skopje 1000",municipality="Centar" }
     };
        public ActionResult Index()
        {
            return View(csList);
        }
        public ActionResult TabularView()
        {
            return View(csList);
        }
        public ActionResult Map()
        {
            return View(csList);
        }
        public ActionResult Details(int id)
        {
            return View(csList.ElementAt(id));
        }
        public ActionResult Detali(int id)
        {
            return View(csList.ElementAt(id));
        }
    }
}