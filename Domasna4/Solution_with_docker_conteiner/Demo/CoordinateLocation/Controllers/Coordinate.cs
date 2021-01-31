using CoordinateLocation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CoordinateLocation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Coordinate : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _config;

        public Coordinate(IConfiguration config, IHttpContextAccessor httpContextAccessor)
        {
            _config = config;
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpGet]
        public string GetLocationCoordinates()
        {
            string ip = CordinateLocation.Functions.IpAddress.GetRequestIP(_httpContextAccessor);
            string json_object = "";
            Json_info_model json_Info_Model = new Json_info_model();
            try
            {
                json_object = new WebClient().DownloadString("http://ipinfo.io/" + ip);
                json_Info_Model = JsonConvert.DeserializeObject<Json_info_model>(json_object);
            }
            catch (Exception)
            {
                json_Info_Model.Coordinates = null;
            }
            return json_Info_Model.Coordinates;
        }
    }
}
