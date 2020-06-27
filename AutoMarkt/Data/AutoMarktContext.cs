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

        public DbSet<EmployeeVehicle> employeeVehicle { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            //ModelBuilder.Entity<Employee>
            //new Employee { Id = "1", Name = "Jhon", LastName = "Smith", Wage = 500, Email = "Jhony@mail.com", Phone = "444555666", EmployeeId = "A2", Education = "High school", Rank = "Junior salesman" };
            //new Employee { Id = "2", Name = "Petar", LastName = "Petkovski", Wage = 500, Email = "PP@mail.com", Phone = "444555888", EmployeeId = "A3", Education = "High school", Rank = "Junior salesman" };
            //new Employee { Id = "3", Name = "Jack", LastName = "Kaiser", Wage = 1000, Email = "JK@mail.com", Phone = "999999999", EmployeeId = "B1", Education = "DI", Rank = "Senior salesman" };



        }


    }
}
