using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Demo.Models;

namespace Demo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Demo.Models.Charging_station> Charging_station { get; set; }
        public DbSet<Demo.Models.Comment> Comment { get; set; }
    }
}
