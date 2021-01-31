using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Demo.Data;
using Demo.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;

namespace Demo.Controllers
{
    [Authorize]
    public class Charging_stationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Charging_stationController(ApplicationDbContext context)
        {
            _context = context;
        }

        //This action is returning the index view of the Charging_station controller. 
        //The index view is showing the list of all charging stations in Skopje.
        //This view is in English language.
        // GET: Charging_station
        public async Task<IActionResult> Index()
        {
            return View(await _context.Charging_station.ToListAsync());
        }


        public async Task<IActionResult> MapAsync()
        {
            //String microServiceURI = "https://localhost:49166";

            String microServiceURI = "http://coordinatelocation:80/";
            var client = new HttpClient();

            // Passing service base url
            client.BaseAddress = new Uri(microServiceURI);

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //Sending request to find web api REST service resource GetUserLocation using HttpClient  
            HttpResponseMessage Res = await client.GetAsync("api/Coordinate");

            //Checking the response is successful or not which is sent using HttpClient 
            Kordinati kordinati = new Kordinati();
            if (Res.IsSuccessStatusCode)
            {
                var ObjResponse = Res.Content.ReadAsStringAsync().Result;
                string[] parts = ObjResponse.ToString().Substring(1, 15).Split(',');
                kordinati.latitude = parts[0];
                kordinati.logitude = parts[1];

            }
            return View(kordinati);
        }

        //This action is returning the index view of the Charging_station controller. 
        //The index view is showing the list of all charging stations in Skopje.
        //This view is in Macedonian language.
        // GET: Charging_station/Tabelaren_prikaz
        public async Task<IActionResult> Tabelaren_prikaz()
        {
            return View(await _context.Charging_station.ToListAsync());
        }

        // GET: Charging_station/Details/5
        //This action is returning the details view of the Charging_station controller. 
        //The details view is showing the details for a selected charging station in Skopje.
        //This view is in English language.
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var charging_station = await _context.Charging_station
                .FirstOrDefaultAsync(m => m.id == id);
            if (charging_station == null)
            {
                return NotFound();
            }

            return View(charging_station);
        }

        // GET: Charging_station/Detali/5
        //This action is returning the details view of the Charging_station controller. 
        //The details view is showing the details for a selected charging station in Skopje.
        //This view is in Macedonian language.
        public async Task<IActionResult> Detali(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var charging_station = await _context.Charging_station
                .FirstOrDefaultAsync(m => m.id == id);
            if (charging_station == null)
            {
                return NotFound();
            }

            return View(charging_station);
        }
    }   
}
