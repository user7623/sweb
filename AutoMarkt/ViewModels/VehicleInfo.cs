using AutoMarkt.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarkt.ViewModels
{
    public class VehicleInfo
    {
        //public IList<Movie> Movies { get; set; }
        //public SelectList Genres { get; set; }
        //public string MovieGenre { get; set; }
        //public string SearchString { get; set; }

        public IList<Vehicle> Vehicles { get; set; }
        
        public SelectList Make { get; set; }

        public SelectList ChassisNumber { get; set; }
    }
}
