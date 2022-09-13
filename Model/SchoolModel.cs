using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.Model
{
    public class SchoolModel
    {
        [Key]
        public int FoodParcelID { get; set; }
        public string FoodName { get; set; }
        public int FoddContent { get; set; }
    }
}
