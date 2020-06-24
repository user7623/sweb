using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMarkt.Models;

namespace AutoMarkt.Models
{
    public class AutoMarktContext : DbContext
    {
        public AutoMarktContext (DbContextOptions<AutoMarktContext> options)
            : base(options)
        {
        }

        public DbSet<AutoMarkt.Models.Vehicle> Vehicle { get; set; }

        public DbSet<AutoMarkt.Models.Employee> Employee { get; set; }

        public DbSet<AutoMarkt.Models.Owner> Owner { get; set; }
    }
}
