using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarkt.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AutoMarktContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<AutoMarktContext>>()))
            {
                if (context.Employee.Any() || context.Vehicle.Any() || context.Owner.Any())
                {
                    return; // DB has been seeded
                }
                context.Owner.AddRange(
                new Owner { Id = "1", Name = "Mr", LastName = "Bean", Phone = "111222333", Email = "Mr_Bean@comedycentral.com"  },
                new Owner { /*Id = 2, */Name = "Mrs", LastName = "Bean", Phone = "111222333", Email = "Mrs_Bean@comedycentral.com" }

                );
                context.SaveChanges();
                context.Employee.AddRange(
                new Employee { Id = "1", Name = "Jhon", LastName = "Smith", Wage = 500 , Email = "Jhony@mail.com", Phone = "444555666", EmployeeId = "A2", Education = "High school", Rank = "Junior salesman"},
                new Employee { /*Id = 2, */Name = "Petar", LastName = "Petkovski", Wage = 500, Email = "PP@mail.com", Phone = "444555888", EmployeeId = "A3", Education = "High school", Rank = "Junior salesman" },
                new Employee { /*Id = 3, */Name = "Jack", LastName = "Kaiser", Wage = 1000, Email = "JK@mail.com", Phone = "999999999", EmployeeId = "B1", Education = "DI", Rank = "Senior salesman" }
                );
                context.SaveChanges();
                context.Vehicle.AddRange(
                new Vehicle
                {
                    Id = "7",
                    Make = "Mercedes A170", cc = 1700, Fuel = "Diesel", EnginePower = 70, Colour = "Black", Price = 2000, Weight = 1100, Approved = true,
                    Description = "Small, quick, economical and very fun to drive.", ChassisNumber = 225588, EmployeeId = "A2"
                },
                new Vehicle
                {
                    Id = "4",   
                    Make = "Mercedes S420",
                    cc = 4200,
                    Fuel = "Diesel",
                    EnginePower = 220,
                    Colour = "White",
                    Price = 19000,
                    Weight = 3000,
                    Approved = true,
                    Description = "Large and very luxurious car with sports car performance.",
                    ChassisNumber = 333444,
                    EmployeeId = "A3"
                },
                new Vehicle
                {
                    Id = "5",    
                    Make = "Audi A6",
                    cc = 2000,
                    Fuel = "Diesel",
                    EnginePower = 90,
                    Colour = "Dark blue",
                    Price = 5000,
                    Weight = 1600,
                    Approved = true,
                    Description = "Large low level luxury car with quiet and economical engine.",
                    ChassisNumber = 775588,
                    EmployeeId = "A1"
                },
                new Vehicle
                {
                    Id = "6",
                    Make = "Kawasaki Ninja",
                    cc = 650,
                    Fuel = "Petrol",
                    EnginePower = 53,
                    Colour = "Light green",
                    Price = 1500,
                    Weight = 186,
                    Approved = true,
                    Description = "Purebred japanese kamikazee machines. Feel the power of 72hp between your legs.",
                    ChassisNumber = 666666,
                    EmployeeId = "A2"
                });
                context.SaveChanges();
                //context.EmployeeVehicle.AddRange
                //(
                //new EmployeeVehicle { ActorId = 8, MovieId = 4 }
                //);
                context.SaveChanges();
            }
        }

    }
}
