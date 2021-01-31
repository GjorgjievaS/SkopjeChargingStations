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

namespace Demo.Controllers
{
    public class Charging_stationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Charging_stationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Charging_station
        public async Task<IActionResult> Index()
        {
            return View(await _context.Charging_station.ToListAsync());
        }

        public async Task<IActionResult> MapAsync()
        {
            String microServiceURI = "https://localhost:44350/";

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

        public async Task<IActionResult> Tabelaren_prikaz()
        {
            return View(await _context.Charging_station.ToListAsync());
        }

        // GET: Charging_station/Details/5
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
