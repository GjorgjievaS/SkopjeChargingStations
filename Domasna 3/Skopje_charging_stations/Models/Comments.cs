using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Skopje_charging_stations.Models
{
    public class Comments
    {
        [Key]
        public String comment { get; set; }
    }
}