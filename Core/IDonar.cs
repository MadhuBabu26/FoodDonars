﻿using FoodDonationManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.Core
{
    public interface IDonar
    {
        public Task AddNewDonar(SchoolModel schoolModel);
        public Task<List<SchoolModel>> DisplayAllDonars();
    }
}
