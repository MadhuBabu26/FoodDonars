using FoodDonationManagementSystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.DataAccess
{
    public class DatabaseContextcs: DbContext
    {
        public DatabaseContextcs(DbContextOptions<DatabaseContextcs> options) : base(options)
        {

        }
        public DbSet<SchoolModel> Donars { get; set; }
    }
}
