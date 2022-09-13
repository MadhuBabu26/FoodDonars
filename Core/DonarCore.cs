using FoodDonationManagementSystem.DataAccess;
using FoodDonationManagementSystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.Core
{
    public class DonarCore : IDonar
    {
        private DatabaseContextcs _databaseContext;
        public DonarCore(DatabaseContextcs databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task AddNewDonar(SchoolModel schoolModel)
        {
            try
            {
                await _databaseContext.Donars.AddAsync(schoolModel);
                await _databaseContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<SchoolModel>> DisplayAllDonars()
        {
            try
            {
                return await _databaseContext.Donars.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

