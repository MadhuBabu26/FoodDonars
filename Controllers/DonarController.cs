using FoodDonationManagementSystem.Core;
using FoodDonationManagementSystem.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonarController : ControllerBase
    {

        private IDonar _donar;
        public DonarController(IDonar donar)
        {
            _donar = donar;
        }
        [HttpPost]
        public async Task<IActionResult> AddNewDonar(SchoolModel schoolModel)
        {
            try
            {
                await _donar.AddNewDonar(schoolModel);
                return Ok("Donar Added Successfully!");
            }
            catch
            {
                return BadRequest("Sorry!Adding Of Donar Failed.");
            }
        }
        [HttpGet]
        public async Task<ActionResult> DisplayDonars()
        {
            try
            {
                var donarList = await _donar.DisplayAllDonars();
                if (donarList.Count != 0)
                {
                    return Ok(donarList);
                }
                else
                {
                    return BadRequest("SOrry!No Donars are available");
                }
            }
            catch
            {
                return BadRequest("Sorry!Getting Donars failed");
            }
        }
    }
}
