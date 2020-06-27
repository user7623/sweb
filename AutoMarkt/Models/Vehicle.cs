using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMarkt.Models
{
    public class Vehicle
    {
        
        public string Id { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Make/Brand")]
        public string Make { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Vehicle colour")]
        public String Colour { get; set; }

        [Required]
        [Display(Name = "Internal engine capacity")]
        public int cc { get; set; }

        [Required]
        [Display(Name = "Vehicle price")]
        [DataType(DataType.Currency)]
        [Range(1, 10000000)]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Engine power in kW")]
        [Range(1, 1000)]
        public int EnginePower { get; set; }

        [Required]
        [Display(Name = "Vehicle weight(in kg)")]
        [Range(1, 200000)]
        public decimal Weight { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Fuel type")]
        public string Fuel { get; set; }

        [Required]
        [Display(Name = "Chassis number")]
        public long ChassisNumber { get; set; }

        [Required]
        [StringLength(300)]
        [Display(Name = "Vehicle short description")]
        public string Description { get; set; }

        public Boolean Approved { get; set; }

        public string pic { get; set; }

        [Required]
        public string EmployeeId { get; set; }

        public DateTime SaleDate {get; set;}

        [StringLength(100)]
        public string BuyerFullname { get; set; }

        public string buyerAddres { get; set; }

        public long BuyerPhone { get; set; }
    }
}
