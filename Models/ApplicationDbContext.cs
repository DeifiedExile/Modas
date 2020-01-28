using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Modas.Models

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        //corresponds with events table
        public DbSet<Event> Events { get; set; }
        //corresponds with locations table
        public DbSet<Location> Locations { get; set; }
    }
}
