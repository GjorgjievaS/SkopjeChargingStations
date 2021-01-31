using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Comment
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Komentari/Comments")]
        public String komentar { get; set; }
    }
}
