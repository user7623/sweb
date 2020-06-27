using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarkt.Models
{
    public class EmployeeVehicle
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int VehicleId { get; set; }

        public Employee employee { get; set; }

        public Vehicle vehicle { get; set; }



    }
}
