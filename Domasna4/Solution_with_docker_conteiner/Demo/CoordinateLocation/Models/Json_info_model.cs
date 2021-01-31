using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoordinateLocation.Models
{
    public class Json_info_model
    {
        [JsonProperty("loc")]
        public string Coordinates { get; set; }

    }
}
