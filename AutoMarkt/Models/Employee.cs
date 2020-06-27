using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarkt.Models
{
    public class Employee
    {
        public string Id { get; set; }

        [Required]
        public String EmployeeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Rank { get; set; }

        [Required]
        public int Wage { get; set; }

        [Required]
        [StringLength(50)]
        public string Education { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string pic { get; set; }

        public int ProfitMade { get; set; }

        public string FullName
        {
            get { return String.Format("{0} {1}", Name, LastName); }
        }

        public ICollection<EmployeeVehicle> Vehicles { get; set; }

    }
}
